/*
 * Created by SharpDevelop.
 * User: RM20212930037
 * Date: 01/06/2022
 * Time: 13:50
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Media;

namespace testee
{
	public class Cenario: PictureBox
	{
		
		public Cenario()
		{
			
//			Parent = this;
			Load("2.jpg");
			Height = Height;
			Width = Width;
			somfundo.Play();
//			SizeMode = PictureBoxSizeMode.StretchImage;
		}
		
		public SoundPlayer somfundo = new SoundPlayer("Loop fundo.wav");
	}
}
