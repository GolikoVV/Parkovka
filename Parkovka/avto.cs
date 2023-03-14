using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parkovka
{
    class Car
    {
        private string number;
    private string color;
    public string Number
    {
        init => this.number = value;
        get => this.number;
    }
    public string Make { init; get; }
    public string Model { init; get; }
    public string Color
    {
        init => this.color = value;
        get => this.color;
    }
}
}