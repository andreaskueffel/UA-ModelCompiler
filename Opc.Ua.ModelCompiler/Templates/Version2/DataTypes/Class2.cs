using System;
using System.Runtime.Serialization;

namespace X
{
    public class OpcDataTypes
    {
        // ***START***
        #region _BrowseName_ Class
#if (!OPCUA_EXCLUDE__BrowseName_)
        /// <remarks />
        /// <exclude />
        [OpcDataType(id: DataTypes._BrowseName_, namespaceUri: _XmlNamespaceUri_)]
        [OpcDataTypeEncoding(id: Objects._BrowseName__Encoding_DefaultBinary, namespaceUri: _XmlNamespaceUri_, Type = OpcEncodingType.Binary)]
        [OpcDataTypeEncoding(id: Objects._BrowseName__Encoding_DefaultXml, namespaceUri: _XmlNamespaceUri_, Type = OpcEncodingType.Xml)]
        public class _BrowseName_ /*: Opc.UaFx.OpcDataTypeNode, IOpcDataType*/
        {
            #region Constructors
            public _BrowseName_() //: base(BoschODM.DataTypeIds._BrowseName_, nameof(_BrowseName_))
            {
                Initialize();
            }

            [OnDeserializing]
            private void Initialize(StreamingContext context)
            {
                Initialize();
            }

            private void Initialize()
            {
                // ListOfFieldInitializers
            }
            #endregion
            #region Public Properties
            // ListOfProperties
            #endregion


            #region Private Fields
            // ListOfFields
            #endregion
        }
        // CollectionClass
#endif
        #endregion
        // ***END***
    }
}