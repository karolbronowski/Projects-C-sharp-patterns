using System;
using Machines;
using RobotIntepreter;

namespace Interpreter
{
    public class ShowInterpreter
    {
        public static void Main()
        {
            MachineComposite krakow = ExampleMachine.Krakow();
            ShellAssembler sa = (ShellAssembler)krakow.Find("Maszyna montażowa:3302");
            StarPress sp = (StarPress)krakow.Find("Prasa:3404");
            UnloadBuffer ub = (UnloadBuffer)krakow.Find("Taśmociąg:3501");

            sa.Load(new Bin(11011));
            sp.Load(new Bin(11015));

            CarryCommand c1 = new CarryCommand(sa, ub);
            CarryCommand c2 = new CarryCommand(sp, ub);

            CommandSequence seq = new CarryCommandSequence();
            seq.AddCommand(c1);
            seq.AddCommand(c2);
            seq.Execute();
        }
    }
}
