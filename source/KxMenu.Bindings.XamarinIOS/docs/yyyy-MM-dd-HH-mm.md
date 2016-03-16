# 2015-01-26


##	Error CS0102: The type  already contains a definition for `p0' 

	~Projects/HolisticWare/Components/Xamarin.Firebase/bindings/Firebase.XamarinAndroid.Binding/obj/Debug/generated/src/Com.Firebase.Client.IValueEventListener.cs(45,45)
		: Error CS0102: 
		The type `Com.Firebase.Client.CancelledEventArgs' already contains a definition for `p0' 
		(CS0102) 
		(Firebase.XamarinAndroid.Binding)
	
	
Search:
	xamarin android bindings
	The type  already contains a definition for `p0' 
	
###	Fix/[re]solution/workaround

	<attr 
		path="/api/package[@name='com.inmobi.androidsdk']/class[@name='AdRequestFailedEventArgs']/field[@name='p0']" 
		name="managedName"
		>
		p0_2
	</attr>
	
NOTE: differ in uppercase!!!

	
##	Error CS0542: member names cannot be the same as their enclosing type

	~/Projects/HolisticWare/Components/Xamarin.Firebase/bindings/Firebase.XamarinAndroid.Binding/obj/Debug/generated/src/Com.Shaded.Fasterxml.Jackson.Databind.Deser.DataFormatReaders.cs(73,73)
		: Error CS0542: 
		`Com.Shaded.Fasterxml.Jackson.Databind.Deser.DataFormatReaders.Match.Match': member names cannot be the same as their enclosing type 
		(CS0542) 
		(Firebase.XamarinAndroid.Binding)
		

	~/Projects/HolisticWare/Components/Xamarin.Firebase/bindings/Firebase.XamarinAndroid.Binding/obj/Debug/generated/src/Com.Shaded.Fasterxml.Jackson.Core.Sym.Name.cs(20,20)
		: Error CS0542: 
		`Com.Shaded.Fasterxml.Jackson.Core.Sym.Name.Name': member names cannot be the same as their enclosing type 
		(CS0542) 
		(Firebase.XamarinAndroid.Binding)		
		
###	Fix/[re]solution/workaround

		
		
		
		
##	Error CS0645: Identifier too long (limit is 512 chars) 

3 related errors

	~/Projects/HolisticWare/Components/Xamarin.Firebase/bindings/Firebase.XamarinAndroid.Binding/obj/Debug/generated/src/Com.Shaded.Fasterxml.Jackson.Databind.Cfg.BaseSettings.cs(17,17)
		: Error CS0645: 
		Identifier too long (limit is 512 chars) 
		(CS0645) 
		(Firebase.XamarinAndroid.Binding)		

	
	
	~/Projects/HolisticWare/Components/Xamarin.Firebase/bindings/Firebase.XamarinAndroid.Binding/obj/Debug/generated/src/Com.Shaded.Fasterxml.Jackson.Databind.Cfg.BaseSettings.cs(48,255+)
		: Error CS1519: 
		Unexpected symbol `e_Lcom_shaded_fasterxml_jackson_core_Base64Variant_' in class, struct, or interface member declaration 
		(CS1519) 
		(Firebase.XamarinAndroid.Binding)
	
	