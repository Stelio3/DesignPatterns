using System.Threading.Tasks;

namespace Enemies.States
{
    public interface IEnemyState
    {
        Task<StateResult> DoAction(object data);
    }
}
