﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neptuo.AspNet.Navigation
{
    [AttributeUsage(AttributeTargets.Class)]
    public class RouteControllerAttribute : Attribute, IRouteDefaultProvider
    {
        /// <summary>
        /// Gets the name of the controller.
        /// </summary>
        public string Controller { get; private set; }

        /// <summary>
        /// Gets the name of the action.
        /// </summary>
        public string Action { get; private set; }

        /// <summary>
        /// Creates new instance with the <paramref name="controller"/> and the <paramref name="action"/>.
        /// </summary>
        /// <param name="controller">The name of the controller.</param>
        /// <param name="action">The name of the action.</param>
        public RouteControllerAttribute(string controller, string action)
        {
            Controller = controller;
            Action = action;
        }

        public IEnumerable<KeyValuePair<string, object>> GetKeyValues()
        {
            return new List<KeyValuePair<string, object>>()
            {
                new KeyValuePair<string, object>(nameof(Controller), Controller),
                new KeyValuePair<string, object>(nameof(Action), Action)
            };
        }
    }
}