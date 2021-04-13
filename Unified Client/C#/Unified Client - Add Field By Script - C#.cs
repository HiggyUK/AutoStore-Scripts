using System;
using NSi.AutoStore.Capture.DataModel;

public class Script
{
    public static void Form_OnLoad(MFPEventData eventData)
    {

		//Dynamically Add new Field to Form
		TextField newField = new TextField();
		newField.Name = "DynamicField";
		newField.Display = "Dynamic Field ";
		newField.IsHidden = false;
		newField.Value = "The value";
		eventData.Form.Fields.Add(newField);
		
    }
    public static void Form_OnSubmit(MFPEventData eventData)
    {
        //TODO add code here to execute when the user presses OK in the form
    }

    public static void fieldName_OnChange(MFPEventData eventData) //TODO change <fieldName> to desired field name
    {
        //TODO add code here to execute when field value of <fieldName> is changed
    }
    public static void fieldName_OnDisplay(MFPEventData eventData)
    {
    }
    public static void fieldName_OnFind(MFPEventData eventData)
    {
    }
    public static void fieldName_OnBrowse(MFPEventData eventData)
    {
    }
}
