namespace ZsutPw.Patterns.WindowsApplication.Controller
{
  using System;
  using System.Collections.Generic;
  using System.Diagnostics;
  using System.Linq;
  using System.Threading.Tasks;

  using ZsutPw.Patterns.WindowsApplication.Model;
  using ZsutPw.Patterns.WindowsApplication.Utilities;

  public static class ControllerFactory
  {
    private static IController controller;

    public static IController GetController( IEventDispatcher dispatch )
    {
      if( controller == null )
      {
        IModel newModel = new Model( dispatch ) as IModel;

        IController newController = new Controller( dispatch, newModel );

        controller = newController;
      }
      return controller;
    }
  }
}
