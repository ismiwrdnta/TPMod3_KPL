using System;
using tpmodul3_1302201135;

namespace tpmodul3_1302201135
{
	public class KodePos
	{
		public string getKodePos(string a)
		{
			string kode;
			if (a == "Batununggal")
			{
				kode = "40266";
			}
			else if (a == "Kujangsari")
			{
				kode = "40287";
			}
			else if (a == "Mengger")
			{
				kode = "40267";
			}
			else if (a == "Wates")
			{
				kode = "40256";
			}
			else if (a == "Cijaura")
			{
				kode = "40287";
			}
			else if (a == "Jatisari")
			{
				kode = "40286";
			}
			else if (a == "Margasari")
			{
				kode = "40286";
			}
			else if (a == "Sekejati")
			{
				kode = "40286";
			}
			else if (a == "Kebonwaru")
			{
				kode = "40272";
			}
			else if (a == "Maleer")
			{
				kode = "40274";
			}
			else
			{
				kode = "40273";
			}
			return kode;
		}
	}
}
