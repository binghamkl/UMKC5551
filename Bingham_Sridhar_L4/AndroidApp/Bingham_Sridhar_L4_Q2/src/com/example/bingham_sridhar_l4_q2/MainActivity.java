package com.example.bingham_sridhar_l4_q2;

import android.os.Bundle;
import android.app.Activity;
import android.view.View;
import android.view.View.OnClickListener;
import android.widget.Button;
import android.widget.EditText;
import android.widget.TextView;
import android.widget.Toast;
import org.ksoap2.*;
import org.ksoap2.serialization.*;
import org.ksoap2.transport.*;



public class MainActivity extends Activity {

	private Button submitButton;
	private EditText searchText;
	private TextView resultText;
	
	@Override
	protected void onCreate(Bundle savedInstanceState) {
		super.onCreate(savedInstanceState);
		setContentView(R.layout.activity_main);
		
		//Set variables to the screen objects
		submitButton = (Button)findViewById(R.id.SearchFirstName);
		searchText = (EditText)findViewById(R.id.FirstName);
		resultText = (TextView)findViewById(R.id.SearchResults);

		//Handle Events
		submitButton.setOnClickListener(submitButtonClick);
	
		Toast.makeText(MainActivity.this, "Enter a First name to see the other members first names.", Toast.LENGTH_LONG).show();

	}
	
	private OnClickListener submitButtonClick = new OnClickListener(){
		@Override
		public void onClick(View v){
			
			try {
				String WSURL = getString(R.string.WSURL);
				HttpTransportSE transport = new HttpTransportSE(WSURL);
				transport.debug = true;
				
				String nameSpace = getString(R.string.NAMESPACE);
				String method = getString(R.string.LookupMembers);
				SoapObject soapObject = new SoapObject(nameSpace, method);
				
				String ParameterName = getString(R.string.LookupMembersFirstNameParameter);
				String ParameterValue = searchText.getText().toString();
				PropertyInfo pi = new PropertyInfo();
				pi.setName(ParameterName);
				pi.setValue(ParameterValue);
				pi.setType(String.class);
				soapObject.addProperty(pi);
				
				//soapObject.addProperty(getString(R.string.LookupMembersFirstNameParameter), searchText.getText());
				
				SoapSerializationEnvelope envelope = new SoapSerializationEnvelope(SoapEnvelope.VER11);
				envelope.dotNet = true;
				envelope.bodyOut = soapObject;
				
				String response = null;
				try		
				{
					transport.call(nameSpace + method, envelope);
					response = envelope.getResponse().toString();
					resultText.setText(response);
				}
				catch (Exception ex)
				{
					resultText.setText("error");
				}
			
			}
			catch (Exception ex)
			{
				resultText.setText("Error");
			
			}
			
		}
	};


}
