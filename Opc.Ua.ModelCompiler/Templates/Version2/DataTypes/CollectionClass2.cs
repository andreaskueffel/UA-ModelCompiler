// ***START***
#region _BrowseName_Collection Class
/// <remarks />
/// <exclude />
[System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
[CollectionDataContract(Name = "ListOf_BrowseName_", Namespace = _XmlNamespaceUri_, ItemName = "_BrowseName_")]
#if !NET_STANDARD
public partial class Ignore_BrowseName_Collection : List<_BrowseName_>, ICloneable
#else
public partial class _BrowseName_Collection : List<_BrowseName_>
#endif
{
    #region Constructors
    /// <remarks />
    public Ignore_BrowseName_Collection() {}

    /// <remarks />
    public Ignore_BrowseName_Collection(int capacity) : base(capacity) {}

    /// <remarks />
    public Ignore_BrowseName_Collection(IEnumerable<_BrowseName_> collection) : base(collection) {}
    #endregion

    #region Static Operators
    /// <remarks />
    public static implicit operator Ignore_BrowseName_Collection(_BrowseName_[] values)
    {
        if (values != null)
        {
            return new Ignore_BrowseName_Collection(values);
        }

        return new Ignore_BrowseName_Collection();
    }

    /// <remarks />
    public static explicit operator _BrowseName_[](Ignore_BrowseName_Collection values)
    {
        if (values != null)
        {
            return values.ToArray();
        }

        return null;
    }
    #endregion

    #if !NET_STANDARD
    #region ICloneable Methods
    /// <remarks />
    public object Clone()
    {
        return (Ignore_BrowseName_Collection)this.MemberwiseClone();
    }
    #endregion
    #endif

    /// <summary cref="Object.MemberwiseClone" />
    public new object MemberwiseClone()
    {
        Ignore_BrowseName_Collection clone = new Ignore_BrowseName_Collection(this.Count);

        for (int ii = 0; ii < this.Count; ii++)
        {
            clone.Add((_BrowseName_)Utils.Clone(this[ii]));
        }

        return clone;
    }
}
#endregion
// ***END***