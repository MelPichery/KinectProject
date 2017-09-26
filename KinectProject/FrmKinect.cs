using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Kinect;
using Microsoft.Kinect.Toolkit;
using Microsoft.Kinect.Toolkit.Controls;
using Microsoft.Kinect.Toolkit.Interaction;

namespace KinectProject
{
	public partial class Form1 : Form
	{
		private KinectSensorChooser _sensorchooser;
		public FrmKinect()
		{
			InitializeComponent();
			
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			_sensorchooser = new KinectSensorChooser();
			_sensorchooser.Start();

		}
	}
}
