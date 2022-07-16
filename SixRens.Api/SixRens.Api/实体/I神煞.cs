using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YiJingFramework.StemsAndBranches;

namespace SixRens.Api.实体
{
    public interface I神煞
    {
        public string 神煞名 { get; }
        public IReadOnlyList<EarthlyBranch> 所在神 { get; }
    }
}
