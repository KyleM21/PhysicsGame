/*
	DOCTYPE JAVASCRIPT
	File:  dark.js
	Name: Kyle Marcoux
    GUI II
    This is the javascript for Dark Mode!!
	Built off of: https://www.developerdrive.com/css-dark-mode/
*/

$(document).ready(function() {
	$( "#dToggle" ).on("click", function() {
		if( $( "body" ).hasClass( "dark" )) {
		  $( "body" ).removeClass( "dark" );
		  $( "#dToggle" ).text( "Lights out" );
		} else {
		  $( "body" ).addClass( "dark" );
		  $( "#dToggle" ).text( "Lights on" );
		}
	});
});