		public void CloseRobloxPlayer() 
		{
			Process[] processesByName = Process.GetProcessesByName("RobloxPlayerBeta");
			for (int process = 0; process < processesByName.Length; process++)
			{
				processesByName[process].Kill();
			}
		}
