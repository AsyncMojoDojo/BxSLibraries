﻿namespace BxSLib_MVVM
{
	using System.Threading.Tasks;
	using System.Windows.Input;
	//•••••••••••••••••••••••••••••••••••••••••••••••••••••••••••••••••••••••••••••••••••••••••••••••
	public interface IAsyncCommand : ICommand
		{
			Task ExecuteAsync(object parameter);
		}
}
