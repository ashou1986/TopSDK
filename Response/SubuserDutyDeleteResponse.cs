using System;
using System.Xml.Serialization;

namespace Top.Api.Response
{
    /// <summary>
    /// SubuserDutyDeleteResponse.
    /// </summary>
    public class SubuserDutyDeleteResponse : TopResponse
    {
        /// <summary>
        /// 操作是否成功 true:操作成功; false:操作失败
        /// </summary>
        [XmlElement("is_success")]
        public bool IsSuccess { get; set; }
    }
}
