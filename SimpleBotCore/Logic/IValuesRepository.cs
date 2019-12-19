using System.Collections.Generic;
using System.Threading.Tasks;
using SimpleBotCore.Logic;

public interface IValuesRepository
{
    Task InsertAsync(SimpleMessage val);
}