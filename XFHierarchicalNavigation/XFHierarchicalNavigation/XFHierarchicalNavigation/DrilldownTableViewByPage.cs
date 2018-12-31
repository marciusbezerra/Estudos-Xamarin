using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace XFHierarchicalNavigation
{
	public class DrilldownTableViewByPage : ContentPage
	{
		public DrilldownTableViewByPage ()
		{
            var navigateCommand = new Command<Type>(async (pageType) => {
                var page = (Page)Activator.CreateInstance(pageType);
                await Navigation.PushAsync(page);
            });

            Title = "Drilldown List usando TableView";

            Content = new TableView {
                Intent = TableIntent.Menu,
                Root = new TableRoot {
                    new TableSection("Português") {
                        new TextCell {
                            Text = "Segunda página",
                            Command = navigateCommand,
                            CommandParameter = typeof(SecondPage)
                        },
                        new TextCell {
                            Text = "Terceira página",
                            Command = navigateCommand,
                            CommandParameter = typeof(ThirdPage)
                        },
                        new TextCell {
                            Text = "Quarta página",
                            Command = navigateCommand,
                            CommandParameter = typeof(FourthPage)
                        }
                    },
                    new TableSection("Español") {
                        new TextCell {
                            Text = "Segunda página",
                            Command = navigateCommand,
                            CommandParameter = typeof(SecondPage)
                        },
                        new TextCell {
                            Text = "Tercera página",
                            Command = navigateCommand,
                            CommandParameter = typeof(ThirdPage)
                        },
                        new TextCell {
                            Text = "Cuarta página",
                            Command = navigateCommand,
                            CommandParameter = typeof(FourthPage)
                        }
                    },
                    new TableSection("English") {
                        new TextCell {
                            Text = "Second page",
                            Command = navigateCommand,
                            CommandParameter = typeof(SecondPage)
                        },
                        new TextCell {
                            Text = "Third page",
                            Command = navigateCommand,
                            CommandParameter = typeof(ThirdPage)
                        },
                        new TextCell {
                            Text = "Fourth page",
                            Command = navigateCommand,
                            CommandParameter = typeof(FourthPage)
                        }
                    }
                },

            };
		}
	}
}