/// <summary>
/// 轮胎属性列表
/// </summary>
namespace doublestartyre.data
{
    public struct tyre
    {
        public string QRcode;//二维码
        public int tyrestatus;//状态
        //-1扫描失败，-2待修补，-3不合格品，1去毛刺，2人工外检，3 X光检测，4动均检测，5气泡抽检，6暂存区队列，7暂存区中，8装箱
        public string tyrestandard; //轮胎规格

    }
}
