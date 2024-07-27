/*
 * Created by SharpDevelop.
 * User: rm20212930037
 * Date: 08/06/2022
 * Time: 13:43
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
namespace testee
{
	/// <summary>
	/// Description of Personagens.
	/// </summary>
	public class Personagens: PictureBox
	{
		public Personagens()
		{
//			SizeMode = PictureBoxSizeMode.StretchImage;
			Height = 200;
			Width = 200;
			BackColor = Color.Transparent;
		}
		public int hp;
		public int speed;
		public int escudo;
		public int dano;
		public PictureBox cenario;
		
	}
	
}
