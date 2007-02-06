namespace Qyoto {
	public struct QPair<T1, T2> {
		public QPair(T1 t1, T2 t2) {
			first = t1; 
			second = t2;
		}

		public T1 first;
		public T2 second;
	}
}
