using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static OOPDesign.CallCenter.CallCenterEnum;

namespace OOPDesign.CallCenter
{
    public class CallHandler
    {
        private readonly Respondent _respondentChainHandler;
        private readonly Manager _managerChainHandler;
        private readonly Director _directorChainHandler;
        public CallHandler(Respondent respondentChainHandler, Manager managerChainHandler, Director directorChainHandler)
        {
            this._respondentChainHandler = respondentChainHandler;
            _managerChainHandler = managerChainHandler;
            _directorChainHandler = directorChainHandler;
        }

        public bool Proceed(string phoneNumber)
        {
            Call c = new(phoneNumber, ELevel.Respondent);

            return _respondentChainHandler.Handle(c);
        }

        public void AddRespondent(Respondent respondent)
        {
            respondent.SetCallHandler(this);
            _respondentChainHandler.SetNextHandler(respondent);
        }

        public void AddManager(Manager manager)
        {
            manager.SetCallHandler(this);
            _managerChainHandler.SetNextHandler(manager);
        }

        public void AddDirector(Director director)
        { 
            director.SetCallHandler(this);
            _directorChainHandler.SetNextHandler(director);
        }
        public bool Escalate(Call call)
        {
            return call.Level switch
            {
                ELevel.Respondent => _respondentChainHandler.Handle(call),
                ELevel.Manager => _managerChainHandler.Handle(call),
                ELevel.Director => _directorChainHandler.Handle(call),
                _ => throw new NotImplementedException()
            };
        }
    }
}
