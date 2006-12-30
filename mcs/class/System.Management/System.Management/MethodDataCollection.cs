//
// System.Management.MethodDataCollection
//
// Authors:
//	Gert Driesen (drieseng@users.sourceforge.net)
//
// (C) 2006 Gert Driesen
//
//
// Permission is hereby granted, free of charge, to any person obtaining
// a copy of this software and associated documentation files (the
// "Software"), to deal in the Software without restriction, including
// without limitation the rights to use, copy, modify, merge, publish,
// distribute, sublicense, and/or sell copies of the Software, and to
// permit persons to whom the Software is furnished to do so, subject to
// the following conditions:
// 
// The above copyright notice and this permission notice shall be
// included in all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
// MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE
// LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION
// OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION
// WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
//

using System;
using System.Collections;

namespace System.Management
{
	[MonoTODO ("System.Management is not implemented")]
	public class MethodDataCollection : ICollection, IEnumerable
	{
		public int Count {
			get {
				throw CreateNotImplementedException ();
			}
		}

		public bool IsSynchronized {
			get {
				throw CreateNotImplementedException ();
			}
		}

		public virtual MethodData this [string methodName] {
			get {
				throw CreateNotImplementedException ();
			}
		}

		public object SyncRoot {
			get {
				throw CreateNotImplementedException ();
			}
		}

		public virtual void Add (string methodName)
		{
			throw CreateNotImplementedException ();
		}

		public virtual void Add (string methodName, ManagementBaseObject inParams, ManagementBaseObject outParams)
		{
			throw CreateNotImplementedException ();
		}

		public void CopyTo (MethodData [] methodArray, int index)
		{
			throw CreateNotImplementedException ();
		}

		public void CopyTo (Array array, int index)
		{
			throw CreateNotImplementedException ();
		}

		public MethodDataEnumerator GetEnumerator ()
		{
			throw CreateNotImplementedException ();
		}

		public virtual void Remove (string methodName)
		{
			throw CreateNotImplementedException ();
		}

		IEnumerator IEnumerable.GetEnumerator ()
		{
			return GetEnumerator ();
		}

		public class MethodDataEnumerator : IEnumerator
		{
			public bool MoveNext ()
			{
				throw CreateNotImplementedException ();
			}

			public void Reset ()
			{
				throw CreateNotImplementedException ();
			}

			public MethodData Current {
				get {
					throw CreateNotImplementedException ();
				}
			}

			object IEnumerator.Current {
				get {
					return Current;
				}
			}
		}

		private static NotImplementedException CreateNotImplementedException ()
		{
			return new NotImplementedException ("System.Management is not implemented.");
		}
	}
}
