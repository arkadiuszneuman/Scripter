using inSolutions.Utilities;

namespace Skryper.Utilities
{
    public class Cl_Messages : inSolutions.Utilities.Cl_ProgramMessages
    {
        private static Cl_Messages vrcProgramMessages;

        private class Cl_ProgramName : I_ProgramName
        {
            public string ProgramName
            {
                get { return "Skrypter"; }
            }
        }

        public Cl_Messages()
            : base(new Cl_ProgramName())
        {
        }

        public static Cl_Messages Messages
        {
            get
            {
                if (vrcProgramMessages == null)
                {
                    vrcProgramMessages = new Cl_Messages();
                }

                return vrcProgramMessages;
            }
        }
    }
}
