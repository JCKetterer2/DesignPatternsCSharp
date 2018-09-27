using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Visitor;

namespace DesignPatternsClass
{
    public abstract class AbstractWheel : IWheel
    {
        private int _size;
        private bool _wide;
        private Spokes _spokes;
        private Bearings _bearings;

        public AbstractWheel(int size, bool wide)
        {
            this._size = size;
            this._wide = wide;

            _spokes = new Spokes();
            _bearings = new Bearings();
        }

        public virtual int Size
        {
            get
            {
                return _size;
            }
        }

        public virtual bool Wide
        {
            get
            {
                return _wide;
            }
        }

        public void AcceptVisitor(IWheelVisitor visitor)
        {
            _spokes.AcceptVisitor(visitor);
            _bearings.AcceptVisitor(visitor);
            visitor.Visit(this);
        }

        public override string ToString()
        {
            return this.GetType().Name + " with a wheel size of " + _size + " inches";
        }

    }
}
