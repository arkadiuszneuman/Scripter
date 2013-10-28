using inSolutions.Utilities;

namespace Skryper.Utilities
{
    public class Cl_ProgramMessages : inSolutions.Utilities.Cl_ProgramMessages
    {
        private static Cl_ProgramMessages vrcProgramMessages;

        private class Cl_ProgramName : I_ProgramName
        {
            public string ProgramName
            {
                get { return "Skrypter"; }
            }
        }

        public Cl_ProgramMessages()
            : base(new Cl_ProgramName())
        {
        }

        public static Cl_ProgramMessages ProgramMessages
        {
            get
            {
                if (vrcProgramMessages == null)
                {
                    vrcProgramMessages = new Cl_ProgramMessages();
                }

                return vrcProgramMessages;
            }
        }
    }
}
