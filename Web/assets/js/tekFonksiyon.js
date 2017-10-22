function tekFonksiyon() 
	{
		$.ajax({
			   type: "POST",
			   url: 'includes/table_getter.php',
			   data:{action:'div1'},
			   success:function(html)
			    {
					//send results to proper div
					$("#container1").html(html);

				}

			  });
			  
			  $.ajax({
			   type: "POST",
			   url: 'includes/table_getter.php',
			   data:{action:'div2'},
			   success:function(html)
			    {
					//send results to proper div
					$("#container2").html(html);

				}

			  });
			  
			  $.ajax({
			   type: "POST",
			   url: 'includes/table_getter.php',
			   data:{action:'div3'},
			   success:function(html)
			    {
					//send results to proper div
					$("#container3").html(html);

				}

			  });
	}