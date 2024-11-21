using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DinoDiner.Data;
using DinoDiner.Data.Entrees;
using DinoDiner.Data.Sides;
using DinoDiner.Data.Drinks;
using Xunit;
using System.Collections;
using System.Collections.Specialized;
using System.ComponentModel;

namespace DataTest.UnitTests
{

    /// <summary>
    /// A generic MenuItem used for testing purposes only.
    /// </summary>
    public class TestItem : MenuItem, INotifyPropertyChanged
    {
        //public override event PropertyChangedEventHandler PropertyChanged;

        public override string Name { get; } = "name";

        public override decimal Price { get; } = 1m;

        public override uint Calories { get; } = 100;

        private List<string> _specialInstructions = new();
        public override List<string> SpecialInstructions { get { return _specialInstructions; } }
    }
    
    /// <summary>
    /// Unit Tests for the Order class.
    /// </summary>
    public class OrderUnitTests 
    {

        /// <summary>
        /// Items added should be in the order list.
        /// </summary>
        [Fact]
        public void AddedItemsShouldBeInOrderList()
        {
            Order order = new();
            MenuItem item1 = new Brontowurst();
            order.Add(item1);
            Assert.True(order.Count > 0);
            MenuItem item2 = new Fryceritops();
            order.Add(item2);
            Assert.True(order.Count > 1);
            MenuItem item3 = new Plilosoda();
            order.Add(item3);
            Assert.True(order.Count > 2);
        }

        /// <summary>
        /// Items removed should not be in the order list.
        /// </summary>
        [Fact]
        public void RemovedItemsShouldNotBeInOrderList()
        {
            Order order = new();
            MenuItem item1 = new Brontowurst();
            order.Add(item1);
            MenuItem item2 = new Fryceritops();
            order.Add(item2);
            MenuItem item3 = new Plilosoda();
            order.Add(item3);
            order.Remove(item1);
            Assert.True(order.Count < 3);
            order.Remove(item2);
            Assert.True(order.Count < 2);
            order.Remove(item3);
            Assert.True(order.Count < 1);
        }

        /// <summary>
        /// Adding an item should trigger a collection changed event.
        /// </summary>
        [Fact]
        public void AddingItemShouldTriggerCollectionChangedEvent()
        {
            Order order = new Order();
            NotifyCollectionChangedEventArgs arg = null;
            TestItem item = new TestItem();
            order.CollectionChanged += (sender, order) => { arg = order; };
            order.Add(item);
            Assert.NotNull(arg);
            Assert.Equal(NotifyCollectionChangedAction.Add, arg.Action);
            Assert.Equal(1, arg.NewItems.Count);
        }

        /// <summary>
        /// Removing an item should trigger a collection changed event.
        /// </summary>
        /*
        [Fact]
        public void RemovingItemShouldTriggerCollectionChangedEvent()
        {
            Order order = new Order();
            NotifyCollectionChangedEventArgs arg = null;
            TestItem item = new TestItem();
            order.CollectionChanged += (sender, order) => { arg = order; };
            order.Remove(item);
            Assert.NotNull(arg);
            Assert.Equal(NotifyCollectionChangedAction.Remove, arg.Action);
            Assert.Equal(1, arg.OldItems.Count);
        }
        */

    }
}
