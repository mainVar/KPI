using System;
using System.Runtime.InteropServices; // for DLLImport
using System.Text; // for StringBuilder
using System.Windows.Forms; // for MessageBox

namespace VoltStandard
{
	/// <summary>
	/// Summary description for C_GPIBDevice.
	/// </summary>
	public class C_GPIBDevice
	{
		/// <summary>
		/// Constructor for GPIB device 
		/// </summary>
		/// <param name="_BrdIndex"></param>
		/// <param name="_PrAddr"></param>
		/// <param name="_SecAddr"></param>
		/// <param name="_TmO"></param>
		/// <param name="_EOI"></param>
		/// <param name="_EOS"></param>
		public C_GPIBDevice(int _BrdIndex, int _PrAddr, int _SecAddr, int _TmO, int _EOI, int _EOS) //constructor
		{
			i_BoardIndex = _BrdIndex;
			i_PrimaryDeviceAddress = _PrAddr;
			i_SecondaryDeviceAddress = _SecAddr;
			i_Timeout = _TmO;
			i_eoi = _EOI;
			i_eos = _EOS; /*
            IbaEOSrd bd/dev 0 = ignore EOS char during reads
non zero = terminate read when EOS char is received
----
            IbaEOSwrt bd/dev 0 = donТt assert EOI line when EOS char is sent
non zero = assert EOI line whenever EOS char is sent
----
            IbaEOScmp bd/dev 0 = 7 bit compare is used when checking for EOS char
non zero = 8 bit compare is used when checking for EOS
char
----
            IbaEOSchar bd/dev 0 = The current EOS char of board or device
            */
                          /*  ibsic makes the board to became Controller-In-Charge */
                          //..    ibsic(0);

            /*  ibdev acquires a device descriptor to use in subsequent
			device-level NI-488 functions.  It opens and initializes a
			device descriptor and configures it according to the input parameters */
            i_DeviceID = ibdev(i_BoardIndex, i_PrimaryDeviceAddress,
				i_SecondaryDeviceAddress, i_Timeout, i_eoi, i_eos);				
			if ((ThreadIbsta() & ERR) != 0) fn_FormGpibErrorMsg("ibdev ERROR");

			/* ibclr sends the GPIB Selected Device Clear (SDC) message
			to the device described by id*/
			ibclr(i_DeviceID);				
			if ((ThreadIbsta() & ERR) != 0) fn_FormGpibErrorMsg("ibclr ERROR");
			
			flag_DeviceIsReady = true;

        //    flag_DeviceIsReady = false;

        }

		#region Constants of GPIB status bit vector : global variable ibsta and wait mask
		const int ERR = 0x8000; // Error detected
		const int TIMO = 0x4000; // Timeout
		const int EEND = 0x2000; // EOI or EOS detected
		const int SRQI = 0x1000; // SRQ detected by CIC
		const int RQS = 0x800; // Device needs service
		const int CMPL = 0x100;  // I/O completed
		const int LOK = 0x80; // Local lockout state
		const int REM = 0x40; // Remote state
		const int CIC = 0x20; // Controller-in-Charge
		const int ATN = 0x10; //  Attention asserted
		const int TACS = 0x8; // Talker active
		const int LACS = 0x4; // Listener active
		const int DTAS = 0x2;  // Device trigger state
		const int DCAS = 0x1;  // Device clear state
		#endregion

		#region Constants of error messages returned in global variable iberr
		const int EDVR = 0x0; // System error
		const int ECIC = 0x1; // Function requires GPIB board to be CIC
		const int ENOL = 0x2; // Write function detected no Listeners
		const int EADR = 0x3; // Interface board not addressed correctly
		const int EARG = 0x4; // Invalid argument to function call
		const int ESAC = 0x5; // Function requires GPIB board to be SAC
		const int EABO = 0x6; // I/O operation aborted
		const int ENEB = 0x7; // Non-existent interface board
		const int EDMA = 0x8; // Error performing DMA
		const int EOIP = 0xa; // I/O operation started before previous operation completed
		const int ECAP = 0xb; // No capability for intended operation
		const int EFSO = 0xc; // File system operation error
		const int EBUS = 0xe; // Command error during device call
		const int ESTB = 0xf;  // Serial poll status byte lost
		const int ESRQ = 0x10; // SRQ remains asserted
		const int ETAB = 0x14; // The return buffer is full
		const int ELCK = 0x15; // Address or board is locked
		#endregion

		#region NI-488 Functions to access Thread-Specific copies of the GPIB global variables
		[DllImport("gpib-32.dll", EntryPoint = "ThreadIbsta")]
		public static extern int ThreadIbsta();

		[DllImport("gpib-32.dll", EntryPoint = "ThreadIberr")]
		public static extern int ThreadIberr();

		[DllImport("gpib-32.dll", EntryPoint = "ThreadIbcnt")]
		public static extern int ThreadIbcnt();

		[DllImport("gpib-32.dll", EntryPoint = "ThreadIbcntl")]
		public static extern System.Int32 ThreadIbcntl();		
		#endregion
		
		#region NI-488 Functions to communicate with devices
		[DllImport("gpib-32.dll", EntryPoint = "ibclr")]
		public static extern int ibclr (int ud);

		[DllImport("gpib-32.dll", EntryPoint = "ibdev")]
		public static extern int ibdev (int ud, int pad, int sad, int tmo, int eot, int eos);

		[DllImport("gpib-32.dll", EntryPoint = "ibonl")]
		public static extern int ibonl (int ud, int v);

		[DllImport("gpib-32.dll", EntryPoint = "ibrd")]
		public unsafe static extern int ibrd (int ud, sbyte* buf, int cnt);

		[DllImport("gpib-32.dll", EntryPoint = "ibwrt")]
		public static extern int ibwrt (int ud, String buf, int cnt); 

		[DllImport("gpib-32.dll", EntryPoint = "ibcmd")]
		public static extern int ibcmd (int ud, String buf, int cnt);		
		#endregion

		#region Variables
		public int i_DeviceID;     //descriptor returned by ibdev
		private int i_BoardIndex;   //index of the access board
		private int i_PrimaryDeviceAddress;
		private int i_SecondaryDeviceAddress;
		private int i_Timeout; //The I/O timeout value
		private int i_eoi;  //end-of-identify mode of the device
		private int i_eos;  //end-of-string character and modes	
		
		private bool flag_BoardCmdWasSentAtLeastOnce = false;

		public bool flag_DeviceIsReady;// init ==true (кос€к)
		public bool flag_BufferMsgWrittenOK;
		public int i_MaximumExpectedReceivedMsgLenth = 100;
		#endregion

		/// <summary>
		/// Write to Device:  BufferMsg = value;   
		/// Read from Device: value = BufferMsg
		/// </summary>
		public string BufferMsg 
		{
			get
			{
				StringBuilder sb_ReceivedData = new StringBuilder();

                unsafe
                {				
					sbyte* psb_DeviceOutputBufferArray = stackalloc sbyte [i_MaximumExpectedReceivedMsgLenth]; // auto-free
				
					/* ibrd reads data from a device into a user buffer */
					ibrd(i_DeviceID, psb_DeviceOutputBufferArray, i_MaximumExpectedReceivedMsgLenth - 1);
				
					//if (!((ThreadIbsta() & ERR) == 0)) fn_FormGpibErrorMsg("ibrd ERROR");	
					//else fn_FormGpibErrorMsg("ibrd OK");
					
					System.Int32 i_NumberOfBytesWaiting = ThreadIbcntl();			
					
					if (i_NumberOfBytesWaiting > 0)
					{
						for (int i = 0; i <= i_NumberOfBytesWaiting - 1; i++) 
						{							
							if (!((((char)(psb_DeviceOutputBufferArray[i])) == '\n') || (((char)(psb_DeviceOutputBufferArray[i])) == '\r'))) 
							{							 
								sb_ReceivedData.Append((char)psb_DeviceOutputBufferArray[i]);
							} // of if
							else break;
						} // of for
					}
					else sb_ReceivedData.Append("нет данных в буфере прибора");
				} // of unsafe
				return sb_ReceivedData.ToString();
			}			
			set
			{				
				/* ibwrt writes data to a device from a user buffer */
				flag_BufferMsgWrittenOK = false;
				ibwrt(i_DeviceID, value, value.Length);	
				if ((ThreadIbsta() & ERR) == 0) flag_BufferMsgWrittenOK = true;
				else fn_FormGpibErrorMsg("ibwrt ERROR");	
			}
		}
        //private void fn_FormGpibErrorMsg(string s_Msg) 
       
        public void fn_FormGpibErrorMsg(string s_Msg)
        {		
			StringBuilder sb_ErrDescription = new StringBuilder();			
			int i_ThrIbstaValue = ThreadIbsta();
			int i_ThrIberrValue = ThreadIberr();

			sb_ErrDescription.Append("ThreadIbsta() = " + i_ThrIbstaValue.ToString() 
				+ "; ThreadIberr() = " + i_ThrIberrValue.ToString());
			sb_ErrDescription.Append("\r\nThreadIbsta = ");
			if ((i_ThrIbstaValue & ERR ) == 1) sb_ErrDescription.Append("  ERR  <NI-488.2 error>");
			if ((i_ThrIbstaValue & TIMO) == 1) sb_ErrDescription.Append("  TIMO <Time limit exceeded>");
			if ((i_ThrIbstaValue & EEND) == 1) sb_ErrDescription.Append("  END  <END or EOS detected>");
			if ((i_ThrIbstaValue & SRQI) == 1) sb_ErrDescription.Append("  SRQI <SRQ interrupt received>");
			if ((i_ThrIbstaValue & RQS ) == 1) sb_ErrDescription.Append("  RQS  <Device requesting service>");
			if ((i_ThrIbstaValue & CMPL) == 1) sb_ErrDescription.Append("  CMPL <I/O completed>");
			if ((i_ThrIbstaValue & LOK ) == 1) sb_ErrDescription.Append("  LOK  <Lockout State>");
			if ((i_ThrIbstaValue & REM ) == 1) sb_ErrDescription.Append("  REM  <Remote State>");
			if ((i_ThrIbstaValue & CIC ) == 1) sb_ErrDescription.Append("  CIC  <Controller-In-Charge>");
			if ((i_ThrIbstaValue & ATN ) == 1) sb_ErrDescription.Append("  ATN  <Attention is asserted>");
			if ((i_ThrIbstaValue & TACS) == 1) sb_ErrDescription.Append("  TACS <Talker>");
			if ((i_ThrIbstaValue & LACS) == 1) sb_ErrDescription.Append("  LACS <Listener>");
			if ((i_ThrIbstaValue & DTAS) == 1) sb_ErrDescription.Append("  DTAS <Device Trigger State>");
			if ((i_ThrIbstaValue & DCAS) == 1) sb_ErrDescription.Append("  DCAS <Device clRedear State>");
			
			sb_ErrDescription.Append("\r\nThreadIberr = ");
			if (i_ThrIberrValue == EDVR) sb_ErrDescription.Append("  EDVR <System error>");
			if (i_ThrIberrValue == ECIC) sb_ErrDescription.Append("  ECIC <Function requires GPIB interface to be CIC>");
			if (i_ThrIberrValue == ENOL) sb_ErrDescription.Append("  ENOL <No Listeners on the GPIB>");
			if (i_ThrIberrValue == EADR) sb_ErrDescription.Append("  EADR <GPIB interface not addressed correctly>");
			if (i_ThrIberrValue == EARG) sb_ErrDescription.Append("  EARG <Invalid argument to function call>");
			if (i_ThrIberrValue == ESAC) sb_ErrDescription.Append("  ESAC <GPIB interface not System Controller as required>");
			if (i_ThrIberrValue == EABO) sb_ErrDescription.Append("  EABO <I/O operation aborted (timeout)>");
			if (i_ThrIberrValue == ENEB) sb_ErrDescription.Append("  ENEB <Nonexistent GPIB interface>");
			if (i_ThrIberrValue == EDMA) sb_ErrDescription.Append("  EDMA <DMA error>");
			if (i_ThrIberrValue == EOIP) sb_ErrDescription.Append("  EOIP <Asynchronous I/O in progress>");
			if (i_ThrIberrValue == ECAP) sb_ErrDescription.Append("  ECAP <No capability for operation>");
			if (i_ThrIberrValue == EFSO) sb_ErrDescription.Append("  EFSO <File system error>");
			if (i_ThrIberrValue == EBUS) sb_ErrDescription.Append("  EBUS <GPIB bus error>");
			if (i_ThrIberrValue == ESTB) sb_ErrDescription.Append("  ESTB <Serial poll status byte queue overflow>");
			if (i_ThrIberrValue == ESRQ) sb_ErrDescription.Append("  ESRQ <SRQ stuck in ON position>");
			if (i_ThrIberrValue == ETAB) sb_ErrDescription.Append("  ETAB <Table problem>");

            else
            sb_ErrDescription.Append("\r\nThreadIbcntl() = " +  ThreadIbcntl().ToString());
			MessageBox.Show(sb_ErrDescription.ToString(), "ќшибка GPIB: " + s_Msg,	MessageBoxButtons.OK, MessageBoxIcon.Error);
		}
		
		/// <summary>
		/// Sends s_Data over GPIB as interface message
		/// </summary>
		/// <param name="s_Data"></param>
		public void fn_SendBoardCmd(String s_Data)
		{
			/* ibcmd sends bytes over the GPIB
			as command bytes (interface messages)*/
			//..    int i_BoardID = 0;
			ibcmd(i_BoardIndex, s_Data, s_Data.Length);
            MessageBox.Show(s_Data+"20");
            // supress the first error message
            if (flag_BoardCmdWasSentAtLeastOnce)
				if ((ThreadIbsta() & ERR) != 0) fn_FormGpibErrorMsg("ibcmd ERROR");
              else flag_BoardCmdWasSentAtLeastOnce = true;
            
		}
	}
}
