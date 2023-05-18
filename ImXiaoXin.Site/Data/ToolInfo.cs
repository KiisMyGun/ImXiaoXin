namespace ImXiaoXin.Site.Data
{
    /// <summary>
    /// 工具信息
    /// </summary>
    public class ToolInfo
    {
        /// <summary>
        /// 编号
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// 网站名称
        /// </summary>
        public string? Name { get; set; }

        /// <summary>
        /// 网站地址
        /// </summary>
        public string? Url { get; set; }

        /// <summary>
        /// 网站描述
        /// </summary>
        public string? Desc { get; set; }

        /// <summary>
        /// 教学视频地址
        /// </summary>
        public string? TeachingVideoUrl { get; set; }
    }
}