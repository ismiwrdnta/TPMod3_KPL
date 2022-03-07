using System;

namespace tpmodul3_1302201135
{
	public class DoorMachine
	{
		enum State { Terbuka, Terkunci };
		public void getDoor(string a)
		{
			if (a == "Terbuka"){
				State state = State.Terbuka;
				if (state == State.Terbuka)
				{
					Console.WriteLine("Pintu Tidak Terkunci");
					
				}
				
			}else if(a == "Terkunci")
            {
				State state = State.Terkunci;
				if (state == State.Terkunci)
				{
					Console.WriteLine("Pintu Terkunci");
				}
			}
			
			
			

			

		}
	}
}
