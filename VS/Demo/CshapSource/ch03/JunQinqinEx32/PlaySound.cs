using System;
using System.Runtime.InteropServices;

namespace JunQinqinEx32
{
	/// <summary>
	/// PlaySound ��ժҪ˵����
	/// </summary>
	public class PlaySound
	{
		private const int SND_SYNC = 0x0;
		private const int SND_ASYNC = 0x1;
		private const int SND_NODEFAULT = 0x2;
		private const int SND_LOOP = 0x8;
		private const int SND_NOSTOP = 0x10;

		public static void Play(string file)
		{
			int flags = SND_ASYNC | SND_NODEFAULT;
			sndPlaySound(file,flags);
		}

		[DllImport("winmm.dll")]  //ʹ��Windows��̬���ӿ��е�media Playý�岥������������
		private extern static int sndPlaySound(string file,int uFlags);
	}
}
