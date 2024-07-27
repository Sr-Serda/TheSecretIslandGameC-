/*
 * Created by SharpDevelop.
 * User: rm20212930037
 * Date: 13/04/2022
 * Time: 13:06
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace testee
{
	/// <summary>
	/// Description of Class2.
	/// </summary>
	public class Heroi: Personagens
			
	{
		public Heroi()
		{
			Load("goku.gif.gif");
			Height = 200;
			Width = 200;
			BackColor = Color.Transparent;
		}
		
		
		public Heroi h1;
		public Heroi h2;
		public Bullet tiro;
		public Bullet tiro2;
//		int contfundo = 0 ,contup = 0;
		
		
		public int speed = 25;
		
		public void Dir(PictureBox fundo, string dbz)
		{
			Load(dbz);
			Left += speed;
				if(Left > 1500)
			{
//					contfundo++;
					Left=0;
					
//					if	(contfundo==1)
//					fundo.Load("cenario kame.jfif");
//					
//					if(contfundo==0)
//					fundo.Load("ceu goku.png.png");
//					
//					if	(contfundo==-1)
//					fundo.Load("R.png");
//					
//					if(Left>=1500 && contup==1)
//						Left=1500;
//					if(contfundo==3)
//						Left=1500;
					
			}
		}
		public void Esq(PictureBox fundo, string dbz2)
		{
			Left -= speed;
			Load(dbz2);
				if(Left <= 0)
			{
//					contfundo--;
					Left=1500;
					
//					if(contfundo==0)
//					fundo.Load("ceu goku.png.png");
//					
////					if	(contfundo==1)
////					fundo.Load("cei.jpg");
//					
//					if	(contfundo==-1)
//					fundo.Load("R.png");
//					
//					if(contfundo==-2)
//						fundo.Load("cenario giku.jfif");
			}
		}
		public void Cima(PictureBox fundo, string dbz4)
		{
			Top -= speed;
			Load(dbz4);
			
				if(Top <= 0)
			{
//					contup++;
					Top=0;
					
					
//					if	(contup==0)
//					fundo.Load("ceu goku.png.png");
//					
//					if	(contup==1)
//					fundo.Load("cei.jpg");
//					
//					if(Left>1500 && contup==1 && contfundo==00)
//						Left=1500;
//					
			}
		}
		public void Baixo(PictureBox fundo, string dbz3)
		{
			Top += speed;
			Load(dbz3);
			
				if(Top >= 700)
			{
					Top=700;
//					contup--;
	
					
//					if	(contup==0)
//					fundo.Load("ceu goku.png.png");
//					
//					if	(contup==1)
//					fundo.Load("cei.jpg");
					
			}
}
		public void atirar1(PictureBox fundo, string dbz5)
		{
			Load(dbz5);
			Load("lordatacando.gif");
			
		
			}
			public void atirar2(PictureBox fundo, string dbz6)
		{
				Load(dbz6);
				Load("morganatacando.gif");
				

			}
}
}
