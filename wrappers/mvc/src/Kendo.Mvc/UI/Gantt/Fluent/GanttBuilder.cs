namespace Kendo.Mvc.UI.Fluent
{
    using System.Collections.Generic;
    using System.Collections;
    using System;

    /// <summary>
    /// Defines the fluent API for configuring the Kendo Gantt for ASP.NET MVC.
    /// </summary>
    public class GanttBuilder<T>: WidgetBuilderBase<Gantt<T>, GanttBuilder<T>> where T : class, IGanttTask
    {
        private readonly Gantt<T> container;
        /// <summary>
        /// Initializes a new instance of the <see cref="Gantt"/> class.
        /// </summary>
        /// <param name="component">The component.</param>
        public GanttBuilder(Gantt<T> component)
            : base(component)
        {
            container = component;
        }

        //>> Fields
        
        /// <summary>
        /// If set to false the widget will not bind to the data source during initialization. In this case data binding will occur when the change event of the
		/// data source is fired. By default the widget will bind to the data source specified in the configuration.
        /// </summary>
        /// <param name="value">The value that configures the autobind.</param>
        public GanttBuilder<T> AutoBind(bool value)
        {
            container.AutoBind = value;

            return this;
        }
        
        /// <summary>
        /// If set to true the user would be able to create new tasks and modify or delete existing ones.
        /// </summary>
        /// <param name="value">The value that configures the editable.</param>
        public GanttBuilder<T> Editable(bool value)
        {
            container.Editable = value;

            return this;
        }
        
        /// <summary>
        /// The configuration of the gantt messages. Use this option to customize or localize the gantt messages.
        /// </summary>
        /// <param name="configurator">The action that configures the messages.</param>
        public GanttBuilder<T> Messages(Action<GanttMessagesSettingsBuilder> configurator)
        {
            configurator(new GanttMessagesSettingsBuilder(container.Messages));
            return this;
        }
        
        /// <summary>
        /// If set to true the user would be able to select tasks in the gantt. This triggers the change event.
        /// </summary>
        /// <param name="value">The value that configures the selectable.</param>
        public GanttBuilder<T> Selectable(bool value)
        {
            container.Selectable = value;

            return this;
        }
        
        /// <summary>
        /// If set to false, the week and month views will show all days of the week. By default these views display only business days.
        /// </summary>
        /// <param name="value">The value that configures the showworkdays.</param>
        public GanttBuilder<T> ShowWorkDays(bool value)
        {
            container.ShowWorkDays = value;

            return this;
        }
        
        /// <summary>
        /// If set to false, the day view will show all hours of the day. By default the view displays only business hours.
        /// </summary>
        /// <param name="value">The value that configures the showworkhours.</param>
        public GanttBuilder<T> ShowWorkHours(bool value)
        {
            container.ShowWorkHours = value;

            return this;
        }
        
        //<< Fields


        
        /// <summary>
        /// Configures the client-side events.
        /// </summary>
        /// <param name="configurator">The client events action.</param>
        /// <example>
        /// <code lang="CS">
        ///  &lt;%= Html.Kendo().Gantt()
        ///             .Name("Gantt")
        ///             .Events(events => events
        ///                 .DataBinding("onDataBinding")
        ///             )
        /// %&gt;
        /// </code>
        /// </example>
        public GanttBuilder<T> Events(Action<GanttEventBuilder> configurator)
        {

            configurator(new GanttEventBuilder(Component.Events));

            return this;
        }
        
    }
}

