using System.Dynamic;

namespace DynamicSerializer;

public class Dynamic : DynamicObject
{
    internal readonly Dictionary<string, object> _dictionary = new();

    public object this[string propertyName]
    {
        get => _dictionary[propertyName];
        set => AddProperty(propertyName, value);
    }


    public override bool TryGetMember(GetMemberBinder binder, out object result)
    {
        return _dictionary.TryGetValue(binder.Name, out result);
    }


    public override bool TrySetMember(SetMemberBinder binder, object value)
    {
        AddProperty(binder.Name, value);
        return true;
    }


    public void AddProperty(string name, object value)
    {
        _dictionary[name] = value;
    }
}