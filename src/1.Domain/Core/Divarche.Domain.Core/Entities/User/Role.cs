namespace Divarche.Domain.Core.Entities.User;

public class Role
{
    #region Properties
    public int Id { get; set; }
    public string Title { get; set; }
    #endregion

    #region NavigationProperties
    public List<User> Users { get; set; }
    #endregion
}