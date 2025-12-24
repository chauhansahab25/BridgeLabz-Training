public class AccessModifiers{
	public static void Main(String[] args){
	public int publicValue{
		public void PublicMethod(){
			Console.WriteLine("Public Method");
		}

	}
	protected int protectedValue{
		protected void ProtectedMethod(){
			Console.WriteLine("Protected Method");
		}
	
	}
	private int privateValue{
		private void PrivateMethod(){
			Console.WriteLine("Private Method");
		}

		public void AccessPrivate(){
		privateValue = 10;
		PrivateMethod();
		}

	}
	internal int internalValue{
		internal void InternalMethod(){
			Console.WriteLine("InternalMethod");
		}

	}
	}
}

//Private Protected
//Protected internal
