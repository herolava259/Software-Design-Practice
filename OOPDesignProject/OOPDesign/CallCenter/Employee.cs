using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static OOPDesign.CallCenter.CallCenterEnum;

namespace OOPDesign.CallCenter;

public abstract class Employee<TEmployee>
    where TEmployee: class
{
    public Guid EmployeeId { get; private set; }

    public ELevel Level { get; private set; }

    public Call? Call { get; private set; }


    public CallHandler? Handler { get; private set; }

    public virtual void SetId(Guid id)
        { this.EmployeeId = id; }

    public virtual void SetLevel(ELevel level)
        { this.Level = level; }

    protected virtual void SetCall(Call? call) { this.Call = call; }


    public virtual void SetCallHandler(CallHandler callHandler)
    {  this.Handler = callHandler; }

    public virtual bool IsAvailable()
        => this.Call == null;

    public virtual bool ReceiveCall(Call c)
    {
        if (!this.IsAvailable())
            return false;

        this.SetCall(c);
        return true;
    }

    public virtual void DisconnectCall()
    {
        SetCall(null);
    }


    protected abstract bool Escalate(Call c);

    public abstract bool Handle(Call c);

    public abstract void Proceed(Call c);

    public abstract void SetNextHandler(TEmployee newHandler);
}
