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
using Coding4Fun.Kinect.WinForm;

namespace FrmKinect
{
	public partial class Form1 : Form
	{
		private KinectSensor kSensor;
		public Form1()
		{
			InitializeComponent();
		}

		private void bStream_Click(object sender, EventArgs e)
		{
			//connexion à la Kinect
			if (bStream.Text == "stream")
			{
				if (KinectSensor.KinectSensors.Count > 0)
				{
					this.bStream.Text = "stop";
					kSensor = KinectSensor.KinectSensors[0];
					KinectSensor.KinectSensors.StatusChanged += KinectSensors_StatusChanged;
				}

				kSensor.Start();
				this.lblConnectionID.Text = kSensor.DeviceConnectionId;
				kSensor.ColorStream.Enable(ColorImageFormat.RgbResolution640x480Fps30);

				kSensor.DepthStream.Enable();

				kSensor.AllFramesReady += KSensor_AllFramesReady;
				//pouvoir utiliser la fonction squelette
				kSensor.SkeletonStream.Enable();
				kSensor.SkeletonStream.TrackingMode = SkeletonTrackingMode.Seated;

			}
			else
			{
				//Arrêter la connexion
				if (kSensor != null && kSensor.IsRunning)
				{
					kSensor.Stop();
					this.bStream.Text = "stream";
					this.pbKinectStream.Image = null;
				}
			}
		}

		private void KSensor_AllFramesReady(object sender, AllFramesReadyEventArgs e)
		{
			using (var frame = e.OpenColorImageFrame())
				if (frame != null)
					pbKinectStream.Image = CreateBitmapFromSensor(frame);
					//pour récupérer l'image de la kinect il faut créer un bitmap

			using (var frame = e.OpenSkeletonFrame())
			{
				//pour récupérer le squelette	
				if (frame != null)
				{
					var skeletons = new Skeleton[frame.SkeletonArrayLength];
					frame.CopySkeletonDataTo(skeletons);

					var TrackedSkeleton = skeletons.FirstOrDefault(s => s.TrackingState == SkeletonTrackingState.Tracked);
					

					if (TrackedSkeleton != null)
					{
						//récupérer la position de la main droite
						var position = TrackedSkeleton.Joints[JointType.HandRight].Position;
						//récupérer les coordonées
						var coordinateMapper = new CoordinateMapper(kSensor);
						var colorPoint = coordinateMapper.MapSkeletonPointToColorPoint(position, ColorImageFormat.InfraredResolution640x480Fps30);
						this.lblPosition.Text = string.Format(" Hand Position X : {0}, Y : {1}", colorPoint.X, colorPoint.Y);
						//liaison de la souris au mouvement de la main droite
						Cursor.Position = new Point(colorPoint.X,colorPoint.Y);
						Cursor.Clip = new Rectangle(this.Location, this.Size);

					}
				}
			}

		}


		private void KinectSensors_StatusChanged(object sender, StatusChangedEventArgs e)
		{
			//pour afficher le changement de statut (connecté, déconnecté...)
			this.lblStatus.Text = kSensor.Status.ToString();
		}

		private Bitmap CreateBitmapFromSensor(ColorImageFrame frame)
		{
			//bitmap : format d'image matricielle décrite point par point
			var pixelData = new byte[frame.PixelDataLength];
			frame.CopyPixelDataTo(pixelData);

			CrazyEffect(pixelData);

			return pixelData.ToBitmap(frame.Width, frame.Height);

		}

		private void CrazyEffect(byte[] pixelData)
		{
			//jouer avec les couleurs
			for (int i = 0; i < pixelData.Length; i += 4)
			{
				var b = pixelData[i];
				var g = pixelData[i + 1];
				var r = pixelData[i + 2];

				r = (byte)(b * 2);
				g = (byte)(r / 0.5);
				b = (byte)(r * g + b);

				pixelData[i] = r;
				pixelData[i + 1] = b;
				pixelData[i + 2] = g;
			}
		}
	}
}
