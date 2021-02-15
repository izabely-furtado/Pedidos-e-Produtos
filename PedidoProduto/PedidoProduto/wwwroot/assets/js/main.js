$(function(){
  $('.menu-sidebar > li > a').find($('.badge.badge-plus')).html('<i class="material-icons">add</i>');
	//Destaque
  $("#destaque").owlCarousel({
      navigation : false,
      slideSpeed : 300,
      paginationSpeed : 400,
      singleItem:true,    
      autoPlay: true,
      stopOnHover: true,
      transitionStyle: 'fade'
  });

  /*Menu Mobile*/
  $("#menu").hide();
 	$('.navbar-toggle').click(function(){
 		if($("#menu").hide()){
 			$("#menu").show();
      $(".bg-content").css('z-index','-1');
      $("body").css('overflow','hidden');
 		}else{
 			$("#menu").hide();
      $(".bg-content").css('z-index','999');
      $("body").css('overflow','auto');
 		}
 	});
 	$('.btn-close').click(function(){
 		$("#menu").hide();
    $(".bg-content").css('z-index','999');
    $("body").css('overflow','auto');
 	});

  /*Menu e Submenu Sidebar*/

  $('.menu-sidebar > li.sub > a').click(function(){
    if($(this).parent().hasClass('open')){
      $(this).parent().removeClass('open');
      $(this).find($('.badge.badge-plus')).html('<i class="material-icons">add</i>');  
      $(this).parent().find('.dropdown-submenu').hide();
    }else {
      $(this).parent().addClass('open')
      $(this).find($('.badge.badge-plus')).html('<i class="material-icons">remove</i>');
      $(this).parent().find('.dropdown-submenu').show();
    }
  });

  /* Light Gallery */
  $('.zoom').lightGallery({
    thumbnail:false,
    controls: false,
    selector: '.item',
    autoplayControls: false,
    enableDrag: false
    /*counter: false*/
  }); 


  
  $('.popup-title a').click(function(){
    if($(this).parent().parent().parent().hasClass('open')){
      $(this).parent().parent().parent().removeClass('open');
      $(this).find('.material-icons').text('add');
    }else{
      $(this).parent().parent().parent().addClass('open');
      $(this).find('.material-icons').text('remove');
    }
  });

  $('.link-open-list').click(function(){
    if($(this).parent().find('.list-theme').hasClass('open')){
      $(this).parent().find('.list-theme').removeClass('open');
    }else{
      $(this).parent().find('.list-theme').addClass('open');
    }
  });

  $('.menu-sidebar-group .btn-sidebar-menu').click(function(){
    if($(this).parent().hasClass('active')){
      $(this).parent().removeClass('active');
      $(this).find('.material-icons').html('menu');
    }else{
      $(this).parent().addClass('active');
      $(this).find('.material-icons').html('clear');
    }
  });

  $( window ).resize(function() {
    if($(this).width()>768){
      if($("#menu").show()){
        $("#menu").hide();
        $(".bg-content").css('z-index','999');
        $("body").css('overflow','auto');
      }
    }
  });

  $('.btn-print').click(function(){
    window.open("noticia-impressao.html",null,"height=700,width=650,status=yes,toolbar=no,menubar=no,location=no");
  });
 
  /*EMISSÃO DE BOLETO*/
  $('.group-choose-people').hide();
  $('.form-people').change(function(){
    if($(this).val()=="pf"){
      $('.group-choose-people').show();
      $('.group-choose-people .group-cpf').show();
      $('.group-choose-people .group-cnpj').hide();
    }else if($(this).val()=="pj"){
      $('.group-choose-people').show();
      $('.group-choose-people .group-cpf').hide();
      $('.group-choose-people .group-cnpj').show();
    }else{
      $('.group-choose-people').hide();
    }
  });
  $('[data-toggle="popover"]').popover();


  /*UPLOAD CUSTOMIZADO*/
  $('.file-field').change(function(){
    $('.file-field-text').val($(this).val());
  });

  /*OUVIDORIA*/
  $('.btn-ouvidoria').click(function(){
      $(this).hide();
      $('.form-ouvidoria').addClass('active');
  });

  $('.galerias.fotos').lightGallery({
    thumbnail:true,
    selector: '.item',
    controls: false,
    autoplayControls: false,
    enableDrag: true
    /*counter: false*/
  }); 

  /*SIMULADOR*/
   $(".linhas-de-creditos > .list-group > .list-group-item > .radio").on('click',function() { 
     $(".linhas-de-creditos > .list-group > .list-group-item > .radio").parent().removeClass('open');
      $(this).parent().addClass('open');
    });

  $('.btn-send-mail').on('click', function () {
    swal({
      title: 'Enviar por e-mail',
      input: 'email',
      confirmButtonColor: '#F29727',
      cancelButtonColor: '#ccc',
      confirmButtonClass: 'btn-radius',
      cancelButtonClass: 'btn-radius',
      inputPlaceholder: 'Digite seu e-mail',
      showCancelButton: true,
      confirmButtonText: 'Enviar',
      cancelButtonText: 'Cancelar',
      showLoaderOnConfirm: true,
      showCloseButton: true,
      allowOutsideClick: true,
      allowEscapeKey: true,
	  inputValidator: function ( email ) {
       return new Promise( function ( resolve, reject ) {
         var regex = /^([a-zA-Z0-9_.+-])+\@(([a-zA-Z0-9-])+\.)+([a-zA-Z0-9]{2,4})+$/;
         if( regex.test( email ) ) {
           resolve()
         } else {
           reject( 'Endereço de e-mail inválido!' )
         }
       })
     }
    }).then(function (email) {
      swal({
          type: 'success',
          html: 'E-mail enviado para: ' + email
      })
       
    });
  });

  /* Login Cliente e Consultor */ 
  $('.btn-forgot-pass').on('click', function () {
    swal({
      title: 'Informe seu e-mail de login',
      input: 'email',
      confirmButtonColor: '#F29727',
      cancelButtonColor: '#ccc',
      confirmButtonClass: 'btn-radius',
      cancelButtonClass: 'btn-radius',
      inputPlaceholder: 'Digite seu e-mail',
      showCancelButton: true,
      confirmButtonText: 'Enviar',
      cancelButtonText: 'Cancelar',
      showLoaderOnConfirm: true,
      showCloseButton: true,
      allowOutsideClick: true,
      allowEscapeKey: true,
	  inputValidator: function ( email ) {
       return new Promise( function ( resolve, reject ) {
         var regex = /^([a-zA-Z0-9_.+-])+\@(([a-zA-Z0-9-])+\.)+([a-zA-Z0-9]{2,4})+$/;
         if( regex.test( email ) ) {
           resolve()
         } else {
           reject( 'Endereço de e-mail inválido!' )
         }
       })
     }
    }).then(function (email) {
      swal({
          type: 'success',
          html: 'Senha enviada via SMS para o nº (27) XXXXX-1234.'
      })
       
    });
  });
  
  
  /*PESSOA JURÍDICA*/

  //Remove itens da tabela
  var removePessoasAutorizada = function(obj){
    obj.parent().parent().remove('tr');   
    if($('#tabelaPessoas').find('tbody tr').length==0){
      $('.add-group.pessoas .add-users').hide();
    }
  } 

  //Remove itens na tabela PESSOAS AUTORIZADAS
  var addPessoasAutorizadas = function(){

      var table = $('#tabelaPessoas');
      var nome  = $('#add_nome').val();
      var cpf = $('#add_cpf').val(); 
      var celular = $('#add_celular').val(); 
      var sexo = $("#add_sexo:checked").val(); 

      if(table != '' && nome != '' && cpf != '' && celular != ''){
        var tr = (
          '<tr class="people-table">' +
            '<td>'+ nome +'</td>'+
            '<td>'+ cpf +'</td>'+
            '<td>'+ celular +'</td>'+
            '<td>'+ sexo +'</td>'+
            '<td align="right"><a href="javascript:" class="btn-clear-pessoas"><i class="material-icons md-18">clear</i></a></td>'+
          '</tr>'
        );

        $('.add-group.pessoas .add-users').show();
        $('#tabelaPessoas').append(tr);
        
      $('#add_nome').val('');
      $('#add_cpf').val('');
      $('#add_celular').val('');
      
      
      }else{
      
        //$('.add-group.pessoas .add-users').hide();
        console.log('Preencha todos os campos.');
        return false;
      }
      
      $('.btn-clear-pessoas').click(function(){ 
        removePessoasAutorizada($(this)); 
      });

  }

  $('.btn-toggle-pessoas').click(function(){ addPessoasAutorizadas(); });



   var removeResponsaveis = function(obj){
    obj.parent().parent().remove('tr');   
    if($('#tabelaResponsaveis').find('tbody tr').length==0){
      $('.add-group.responsaveis .add-users').hide();
    }
  } 

  //Remove itens na tabela PESSOAS AUTORIZADAS
  var addResponsaveis = function(){

      var table = $('#tabelaResponsaveis');
      var nome  = $('#add_nome_responsavel').val();
      var cpf = $('#add_cpf_responsavel').val(); 

      if(table != '' && nome != '' && cpf != ''){
        var tr = (
          '<tr class="people-table">' +
            '<td>'+ nome +'</td>'+
            '<td>'+ cpf +'</td>'+
            '<td align="right"><a href="javascript:" class="btn-clear-responsaveis"><i class="material-icons md-18">clear</i></a></td>'+
          '</tr>'
        );

        $('.add-group.responsaveis .add-users').show();
        $('#tabelaResponsaveis').append(tr);
        
        $('#add_nome_responsavel').val('');
        $('#add_cpf_responsavel').val('');

      }else{
      
        //$('.add-group.responsaveis .add-users').hide();
        console.log('Preencha todos os campos.');
        return false;
      }
      
      $('.btn-clear-responsaveis').click(function(){ 
        removeResponsaveis($(this)); 
      });

  }

  $('.btn-toggle-responsaveis').click(function(){ addResponsaveis(); });

  //BTN MORE
  $('.btn-more').mouseenter(function(){
    $(this).addClass('active');
  });
  $('.btn-more').mouseleave(function(){
    $(this).removeClass('active');
  });

});