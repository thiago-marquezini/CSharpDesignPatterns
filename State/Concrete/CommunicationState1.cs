using StatePattern.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace StatePattern.Concrete
{
    public class CommunicationState1 : State
    {
        public override void Handle(Context context)
        {
            if (!this.isConnected)
                context.State = new CommunicationState2();
        }
    }
}
