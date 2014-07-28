using System;


namespace ch9_8
{
	
	//�Զ���ӿ�
	interface DemoInterface
	{
	}
    //�Զ�������
	class DemoAttr : System.Attribute
	{
	}
    //�Զ���ö��
	enum DemoEnum
	{
	}
    //�Զ�����
	public class DemoBaseClass
	{
	}
    //�Զ���̳���
	public class DemoDerivedClass : DemoBaseClass
	{
	}
    //�Զ���ṹ
	struct DemoStruct
	{
	}


	
	/// <summary>
	/// Class1 ��ժҪ˵����
	/// </summary>
	class Class1
	{
		
		/// <summary>
		/// Ӧ�ó��������ڵ㡣
		/// </summary>
		[STAThread]
		static void Main(string[] args)
		{
			//
			// TODO: �ڴ˴���Ӵ���������Ӧ�ó���
			//
			QueryTypeInfo("System.Int32");
			Console.WriteLine();

			QueryTypeInfo("System.Int64");
			Console.WriteLine();

			QueryTypeInfo("System.Type");
			Console.WriteLine();
         
			QueryTypeInfo("ch9_8.DemoAttr");
			Console.WriteLine();

			QueryTypeInfo("ch9_8.DemoEnum");
			Console.WriteLine();

			QueryTypeInfo("ch9_8.DemoBaseClass");
			Console.WriteLine();

			QueryTypeInfo("ch9_8.DemoDerivedClass");
			Console.WriteLine();

			QueryTypeInfo("ch9_8.DemoStruct");

		}

		public static void QueryTypeInfo(string typeName)
			{
				try
				{
					//���������
					Type type = Type.GetType(typeName);
					//������͵ľ�����Ϣ
					Console.WriteLine("Type name: {0}", type.FullName);
					Console.WriteLine("HasElementType = {0}",
						type.HasElementType);
					Console.WriteLine("IsAbstract = {0}", type.IsAbstract);
					Console.WriteLine("IsAnsiClass = {0}", type.IsAnsiClass);
					Console.WriteLine("IsArray = {0}", type.IsArray);
					Console.WriteLine("IsAutoClass = {0}", type.IsAutoClass);
					Console.WriteLine("IsAutoLayout = {0}",
						type.IsAutoLayout);
					Console.WriteLine("IsByRef = {0}", type.IsByRef);
					Console.WriteLine("IsClass = {0}", type.IsClass);
					Console.WriteLine("IsCOMObject = {0}", type.IsCOMObject);
					Console.WriteLine("IsContextful = {0}",
						type.IsContextful);
					Console.WriteLine("IsEnum = {0}", type.IsEnum);
					Console.WriteLine("IsExplicitLayout = {0}", 
						type.IsExplicitLayout);
					Console.WriteLine("IsImport = {0}", type.IsImport);
					Console.WriteLine("IsInterface = {0}",
						type.IsInterface);
					Console.WriteLine("IsLayoutSequential = {0}",
						type.IsLayoutSequential);
					Console.WriteLine("IsMarshalByRef = {0}",
						type.IsMarshalByRef);
					Console.WriteLine("IsNestedAssembly = {0}",
						type.IsNestedAssembly);
					Console.WriteLine("IsNestedFamANDAssem = {0}",
						type.IsNestedFamANDAssem);
					Console.WriteLine("IsNestedFamily = {0}",
						type.IsNestedFamily);
					Console.WriteLine("IsNestedFamORAssem = {0}",
						type.IsNestedFamORAssem);
					Console.WriteLine("IsNestedPrivate = {0}",
						type.IsNestedPrivate);
					Console.WriteLine("IsNestedPublic = {0}",
						type.IsNestedPublic);
					Console.WriteLine("IsNotPublic = {0}", 
						type.IsNotPublic);
					Console.WriteLine("IsPointer = {0}", 
						type.IsPointer);
					Console.WriteLine("IsPrimitive = {0}", 
						type.IsPrimitive);
					Console.WriteLine("IsPublic = {0}", 
						type.IsPublic);
					Console.WriteLine("IsSealed = {0}", 
						type.IsSealed);
					Console.WriteLine("IsSerializable = {0}",
						type.IsSerializable);
					Console.WriteLine("IsSpecialName = {0}",
						type.IsSpecialName);
					Console.WriteLine("IsUnicodeClass = {0}",
						type.IsUnicodeClass);
					Console.WriteLine("IsValueType = {0}", type.IsValueType);
				}
				catch(System.NullReferenceException)
				{
					Console.WriteLine
						("{0} is not a valid type", typeName);
				}
			}
	}
}
