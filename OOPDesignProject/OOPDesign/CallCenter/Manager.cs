using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static OOPDesign.CallCenter.CallCenterEnum;

namespace OOPDesign.CallCenter
{
    public class Manager : Employee<Manager>
    {
        public Manager? _nextHandler { get; private set; }

        public Manager(Manager? nextHandler = null)
        {
            this._nextHandler = nextHandler;
        }
        public override void SetNextHandler(Manager newHandler)
        {
            if (_nextHandler == null) _nextHandler = newHandler;

            _nextHandler.SetNextHandler(newHandler);
        }
        public override bool Handle(Call c)
        {
            if ((int)c.Level > (int)ELevel.Respondent)
                return this.Handler!.Escalate(c);

            if (this.IsAvailable())
            {
                Proceed(c);

                return true;
            }

            if (this._nextHandler != null)
                return _nextHandler.Handle(c);

            return this.Handler!.Escalate(c);

        }

        public override void Proceed(Call c)
        {
            SetCall(c);
            Console.WriteLine($"Procceed call phone number: {c.PhoneNumber}, Level: {c.Level.ToString()}");
            DisconnectCall();
        }

        protected override bool Escalate(Call c)
            => this.Handler!.Escalate(c.Escalate());
    }
}
