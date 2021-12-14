namespace CleanArchitecture.Application {
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public interface IBasicViewpoint<TController, TPresenter>
        where TController : IBasicController
        where TPresenter : IBasicPresenter {
        TController Controller {
            get; set;
        }
        TPresenter Presenter {
            get; set;
        }
    }

    public interface IBasicViewpoint : IBasicViewpoint<IBasicController, IBasicPresenter> {
    }
}
