﻿//===============================================================================
//
// PlaZa System Platform
//
//===============================================================================
//
// Warsaw University of Technology
// Computer Networks and Services Division
// Copyright © 2020 PlaZa Creators
// All rights reserved.
//
//===============================================================================

namespace ZsutPw.Patterns.Application.Controller
{
  using System;
  using System.Collections.Generic;
  using System.Diagnostics;
  using System.Linq;
  using System.Threading.Tasks;

  using ZsutPw.Patterns.Application.Model;
  using ZsutPw.Patterns.Application.Utilities;

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
