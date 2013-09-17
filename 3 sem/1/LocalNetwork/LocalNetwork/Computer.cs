
namespace LocalNetwork
{
    public class Computer
    {
        public Computer(char operationSystem, int isInfect)
        {
            if (operationSystem == 'w')
            {
                this.OperationSystem = OS.Windows;
            }
            if (operationSystem == 'l')
            {
                this.OperationSystem = OS.Linux;
            }
            if (operationSystem == 'm')
            {
                this.OperationSystem = OS.Mac;
            }
            if (isInfect == 1)
            {
                this.Virus = true;
            }
            else
            {
                this.Virus = false;
            }
            probability = 0;
        }

        /// <summary>
        /// This function use to infect computer.
        /// </summary>
        public void Infection()
        {
            if (this.Virus)
            {
                return;
            }
            if (this.probability > 50)
            {
                this.Virus = true;
                return;
            }
            if (this.OperationSystem == OS.Windows)
            {
                this.probability += probabilityWindows;
            }
            if (this.OperationSystem == OS.Linux)
            {
                this.probability += probabilityLinux;
            }
            if (this.OperationSystem == OS.Mac)
            {
                this.probability += probabilityMac;
            }
        }

        public OS OperationSystem
        {
            get;
            private set;
        }

        public bool Virus
        {
            get;
            private set;
        }

        public enum OS { Windows, Linux, Mac };

        private int  probabilityWindows = 30;
        private int probabilityLinux = 20;
        private int probabilityMac = 15;
        private int probability;
    }
}
