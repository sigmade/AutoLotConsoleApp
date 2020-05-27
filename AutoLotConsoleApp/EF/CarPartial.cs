using System;

namespace AutoLotConsoleApp.EF
{
    public partial class Car
    {
        public override string ToString()
        {
            // Т.к. столбец PetName может быть пустым предоставим стандартное имя
            return  $"{this.CarNickName ?? "*No Name*"} is a {this.Color} {this.Make} with ID {this.CarId}.";
        }
    }
}
