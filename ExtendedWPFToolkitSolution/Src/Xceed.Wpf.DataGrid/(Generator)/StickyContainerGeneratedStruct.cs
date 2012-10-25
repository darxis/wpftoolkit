﻿/************************************************************************

   Extended WPF Toolkit

   Copyright (C) 2010-2012 Xceed Software Inc.

   This program is provided to you under the terms of the Microsoft Public
   License (Ms-PL) as published at http://wpftoolkit.codeplex.com/license 

   This program can be provided to you by Xceed Software Inc. under a
   proprietary commercial license agreement for use in non-Open Source
   projects. The commercial version of Extended WPF Toolkit also includes
   priority technical support, commercial updates, and many additional 
   useful WPF controls if you license Xceed Business Suite for WPF.

   Visit http://xceed.com and follow @datagrid on Twitter.

  **********************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;

namespace Xceed.Wpf.DataGrid
{
  internal struct StickyContainerGenerated
  {
    #region CONSTRUCTORS

    public StickyContainerGenerated( DependencyObject container, int index, bool isNewlyRealized )
      : this()
    {
      this.StickyContainer = container;
      this.Index = index;
      this.IsNewlyRealized = isNewlyRealized;
    }

    #endregion CONSTRUCTORS

    #region StickyContainer Property

    public DependencyObject StickyContainer
    {
      get;
      private set;
    }

    #endregion StickyContainer Property

    #region IsNewlyRealized Property

    public bool IsNewlyRealized
    {
      get;
      private set;
    }

    #endregion IsNewlyRealized Property

    #region Index Property

    public int Index
    {
      get;
      set;
    }

    #endregion Index Property

    #region Overrides

    public override bool Equals( object obj )
    {
      return object.Equals( obj, this.StickyContainer );
    }

    public override int GetHashCode()
    {
      return this.StickyContainer.GetHashCode();
    }

    #endregion Overrides
  }
}