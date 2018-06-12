using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using CyUSB;

namespace CyUsbTransaction
{
    public class USBComm
    {
        #region Private Fields
        private USBDeviceList _USBDevices;
        private CyUSBDevice _APDUsbDevice;
        private CyUSBEndPoint _InPoint;
        private CyUSBEndPoint _OutPoint;

        private int _USBVid;
        private int _USBPid;

        Thread _ReceiveDataThread;
        private bool _IsReceiving;
        #endregion Private Fields

        #region Public Properties
        public bool IsParametersData { get; set; }
        public byte[] ReceiveBuffer { get; private set; }
        public byte[] ParametersReceiveBuffer { get; private set; }
        public bool APDUsbIsAlive { get; private set; }
        public int BufSz { get; private set; }
        #endregion Public Properties

        #region Constructor
        public USBComm(int vid = 0x04b4, int pid = 0x00f1, int ppx = 16)
        {
            _USBVid = vid;
            _USBPid = pid;
            // Create the list of USB devices attached to the CyUSB.sys driver.
            _USBDevices = new USBDeviceList(CyConst.DEVICES_CYUSB);
            //Assign event handlers for device attachment and device removal.
            _USBDevices.DeviceAttached += _USBDevices_DeviceAttached;
            _USBDevices.DeviceRemoved += _USBDevices_DeviceRemoved;
            //Set and search the device with VID-PID 04b4-1003 and if found, selects the end point
        }

        private void _USBDevices_DeviceRemoved(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void _USBDevices_DeviceAttached(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
        #endregion Constructor
    }
}
