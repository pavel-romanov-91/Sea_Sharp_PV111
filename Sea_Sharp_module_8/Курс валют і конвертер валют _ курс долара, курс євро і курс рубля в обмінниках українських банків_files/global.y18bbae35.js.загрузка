var ref = document.referrer.toLowerCase();
if (ref.indexOf('autosurf-ru.com') !=-1 || ref.indexOf('hitstream.net') !=-1)
	window.location.href = 'http://i.ua/r.php?3';

console = window.console || { log: function(){} }

function i_showFloat(act, url, suf)
{
	if (window.I_VER3)
		return i_showFloat3(act, url);

	if (window.I_VER2)
		return i_showFloat2(act, url);

	if (typeof(suf) == 'undefined')
		suf = 'Login';

	var ab = document.getElementById('Float' + suf);
	var m = document.getElementById('FloatMask' + suf);
	var dis;

	if(act) {
		m.style.display = 'block';
		if (b.opera)
			m.style.background = 'none';
		var sHeight = !b.ie ? window.innerHeight : m.offsetHeight;
		var bHeight = self.document.body.offsetHeight;
		var bWidth = self.document.body.offsetWidth;
		var scrollTop = document.body.scrollTop || document.documentElement.scrollTop;
		ab.style.overflow = 'auto';
		m.style.height = bHeight + 'px';
		ab.style.display = 'block';
		ab.style.left = (bWidth - ab.offsetWidth)/2 + 'px';
		if(!b.moz){
			ab.focus();
			ab.style.outline = 'none';
		}
		dis = 'hidden';
		if (url)
			document.lFloat._url.value = url;
		if (suf == 'Login')
			setTimeout('document.lFloat.login.focus();', 100);
	} else {
		ab.style.display = 'none';
		m.style.display = 'none';
		dis = 'visible';
	}

	toggleDisplay('SELECT', dis);
	toggleDisplay('OBJECT', dis);
	toggleDisplay('EMBED', dis);
	toggleDisplay('IFRAME', dis);

	return false;
}

function i_showFloat2(act, url)
{
	var suf = 'Login';
	var ab = document.getElementById('Float' + suf);
	var m = document.getElementById('FloatMask' + suf);

	if (!ab) {
		ab = document.createElement('DIV');
		ab.id = 'Float' + suf
		ab.className = 'popup login';
		ab.onkeydown = function (evt) { if ((evt || window.event).keyCode == 27) i_showFloat(0); };

		//var loginUrl = 'http://' + (window.DEV ? 'd.ua' : 'i.ua') + '/lin.php';
		var loginUrl = 'https://passport.' + (window.DEV_HOST ? window.DEV_HOST : 'i.ua') + '/login/';
		innerHTML = '';
		innerHTML += '<i class="shadow"></i>';
		innerHTML += '<div class="content clear">';
		innerHTML += '<i class="close_button" onclick="i_showFloat(0);" title="' + i_s('закрыть', 'закрити') + '"></i>';
		innerHTML += '<h2>' + i_s('Паспорт', 'Паспорт') + '</h2>';
		innerHTML += '<div class="form">';
		innerHTML += '<form name="lFloat" method="post" action="' + loginUrl + '" onsubmit="return i_lForm(this);">';
		innerHTML += '<input type="hidden" name="_subm" value="lform" />';
		innerHTML += '<input type="hidden" name="cpass" />';
		innerHTML += '<input type="hidden" name="_rand" />';
		innerHTML += '<input type="hidden" name="scode" />';
		innerHTML += '<input type="hidden" name="_url" />';
		innerHTML += '<fieldset>';
		innerHTML += '<a class="float_right" href="http://passport.i.ua/registration/?_url=' + escape(url ? url : window.location.href) + '">' + i_s('зарегистрироваться', 'зареєструватись') + '</a>';
		innerHTML += '<h4>' + i_s('Логин', 'Логін') + '</h4>';
		innerHTML += '<p><input type="text" name="login" class="width_100" tabindex="2" /></p>';
		innerHTML += '<a class="float_right" href="http://passport.i.ua/recover/">' + i_s('напомнить пароль', 'нагадати пароль') + '</a>';
		innerHTML += '<h4>' + i_s('Пароль', 'Пароль') + '</h4>';
		innerHTML += '<p><input type="password" name="pass" class="width_100" tabindex="2" maxlength="32" /></p>';
		innerHTML += '<label><input type="checkbox" name="auth_type" value="1" tabindex="2" /> ' + i_s('запомнить меня', "запам'ятати мене") + '</label>';
		innerHTML += '</fieldset>';
		innerHTML += '<input value="' + i_s('Войти', 'Увійти') + '" tabindex="2" type="submit" />';
		//innerHTML += ' <input value="' + i_s('Я передумал', 'Я передумав') + '" onclick="i_showFloat(0);" type="button" />';
		innerHTML += ' ' + i_s('через', 'через') + ':';
		var I_MAIN_DOMAIN = window.DEV_HOST ? '.' + window.DEV_HOST : '.i.ua';
		innerHTML += ' <span class="facebook_20" onclick="window.open(\'http://passport' + I_MAIN_DOMAIN + '/socialRedirectPoint/1/redirectToAuth/' + window.location.host + '\', \'_blank\', \'width=1024,height=400,resizable=yes,scrollbars=yes,status=yes\')"><i></i></span>';
		innerHTML += ' <span class="vkontakte_20" onclick="window.open(\'http://passport' + I_MAIN_DOMAIN + '/socialRedirectPoint/2/redirectToAuth/' + window.location.host + '\', \'_blank\', \'width=1024,height=400,resizable=yes,scrollbars=yes,status=yes\')"><i></i></span>';
		innerHTML += ' <span class="twitter_20" onclick="window.open(\'http://passport' + I_MAIN_DOMAIN + '/socialRedirectPoint/3/redirectToAuth/' + window.location.host + '\', \'_blank\', \'width=1024,height=400,resizable=yes,scrollbars=yes,status=yes\')"><i></i></span>';
		innerHTML += ' <span class="googleplus_20" onclick="window.open(\'http://passport' + I_MAIN_DOMAIN + '/socialRedirectPoint/4/redirectToAuth/' + window.location.host + '\', \'_blank\', \'width=1024,height=400,resizable=yes,scrollbars=yes,status=yes\')"><i></i></span>';
		innerHTML += ' <span class="yandex_20" onclick="window.open(\'http://passport' + I_MAIN_DOMAIN + '/socialRedirectPoint/6/redirectToAuth/' + window.location.host + '\', \'_blank\', \'width=1024,height=400,resizable=yes,scrollbars=yes,status=yes\')"><i></i></span>';
		innerHTML += '</form></div></div></div>';
		ab.innerHTML = innerHTML;

		m = document.createElement('IFRAME');
		m.src = 'about:blank';
		m.id = 'FloatMask' + suf

		var h = document.body.offsetHeight + 'px';
		m.frameBorder = 0;
		//m.marginHeight = 0;
		//m.marginWidth = 0;
		m.allowTransparency = true;
		m.disabled = true;
		//m.canHaveChildren = false;
		//m.canHaveHTML = false;
		//m.innerHTML = null;
		m.datasrc = null;
		m.width = '100%';
		m.height = h;
		m.style.position = 'absolute';
		m.style.zIndex = 254;
		m.style.left = 0;
		m.style.top = 0;
		//m.style.border = 'none';
		m.style.opacity = '.75';
		m.style.filter = 'alpha(opacity = 75)';
		m.style.backgroundColor = '#FFFFFF';

		document.body.appendChild(m);
		document.body.appendChild(ab);

		ab.style.marginTop = (- ab.offsetHeight / 2) + 'px';
	}

	if (act) {
		m.style.display = '';
		ab.style.display = '';
		if (url)
			document.forms.lFloat._url.value = url;
		if (suf == 'Login')
			setTimeout('document.forms.lFloat.login.focus();', 100);

//		i_updateSCode();
//		Autoload.call('hex_md5', '');
	} else {
		ab.style.display = 'none';
		m.style.display = 'none';
	}

	return false;
}

function i_showFloat3(act, url) {
	var suf = 'Login';
	var ab = document.getElementById('Float' + suf);
	var m = document.getElementById('FloatMask' + suf);

	if (!ab) {
		ab = document.createElement('DIV');
		ab.id = 'Float' + suf
		ab.className = 'popup popup-fixed popup-login';
		ab.onkeydown = function(evt) {
			if ((evt || window.event).keyCode == 27)
				i_showFloat(0);
		};

				var I_MAIN_DOMAIN = window.I_MAIN_DOMAIN || (window.DEV_HOST ? '.' + window.DEV_HOST : '.i.ua');
				var loginUrl = 'https://passport' + I_MAIN_DOMAIN + '/login/';
		var innerHTML = '';
		innerHTML += '<i class="icon i_closeitem" onclick="i_showFloat(0);" title="' + i_s('закрыть', 'закрити') + '"></i>';
		innerHTML += '<h2>' + i_s('Паспорт', 'Паспорт') + '</h2>';
		innerHTML += '<div class="form form-login">';
		innerHTML += '<form name="lFloat" method="post" action="' + loginUrl + '" onsubmit="return i_lForm(this);">';
		innerHTML += '<input type="hidden" name="_subm" value="lform" />';
		innerHTML += '<input type="hidden" name="cpass" />';
		innerHTML += '<input type="hidden" name="_rand" />';
		innerHTML += '<input type="hidden" name="scode" />';
		innerHTML += '<input type="hidden" name="_url" />';
		innerHTML += '<div class="form_item">';
		innerHTML += '<a class="_help" href="http://passport.i.ua/registration/?_url=' + escape(url ? url : window.location.href) + '">' + i_s('зарегистрироваться', 'зареєструватись') + '</a>';
		innerHTML += '<h4>' + i_s('Логин', 'Логін') + '</h4>';
		innerHTML += '<input type="text" name="login" class="width_100" tabindex="2" />';
		innerHTML += '</div>';
		innerHTML += '<div class="form_item">';
		innerHTML += '<a class="_help" href="http://passport.i.ua/recover/">' + i_s('напомнить пароль', 'нагадати пароль') + '</a>';
		innerHTML += '<h4>' + i_s('Пароль', 'Пароль') + '</h4>';
		innerHTML += '<input type="password" name="pass" class="width_100" tabindex="2" maxlength="32" />';
		innerHTML += '</div>';
		innerHTML += '<div class="form_item">';
		innerHTML += '<label><input type="checkbox" name="auth_type" value="1" tabindex="2" /> ' + i_s('запомнить меня', "запам'ятати мене") + '</label>';
		innerHTML += '</div>';
		innerHTML += '<div class="form_item form_item-submit">';
		innerHTML += '<input value="' + i_s('Войти', 'Увійти') + '" tabindex="2" type="submit" />';
		//innerHTML += ' <input value="' + i_s('Я передумал', 'Я передумав') + '" onclick="i_showFloat(0);" type="button" />';
		innerHTML += ' ' + i_s('через', 'через') + ':';
		innerHTML += ' <span class="icon-l i_fb" onclick="window.open(\'http://passport' + I_MAIN_DOMAIN + '/socialRedirectPoint/1/redirectToAuth/' + window.location.host + '\', \'_blank\', \'width=1024,height=400,resizable=yes,scrollbars=yes,status=yes\')"><i></i></span>';
		innerHTML += ' <span class="icon-l i_vk" onclick="window.open(\'http://passport' + I_MAIN_DOMAIN + '/socialRedirectPoint/2/redirectToAuth/' + window.location.host + '\', \'_blank\', \'width=1024,height=400,resizable=yes,scrollbars=yes,status=yes\')"><i></i></span>';
		innerHTML += ' <span class="icon-l i_tw" onclick="window.open(\'http://passport' + I_MAIN_DOMAIN + '/socialRedirectPoint/3/redirectToAuth/' + window.location.host + '\', \'_blank\', \'width=1024,height=400,resizable=yes,scrollbars=yes,status=yes\')"><i></i></span>';
		innerHTML += ' <span class="icon-l i_gp" onclick="window.open(\'http://passport' + I_MAIN_DOMAIN + '/socialRedirectPoint/4/redirectToAuth/' + window.location.host + '\', \'_blank\', \'width=1024,height=400,resizable=yes,scrollbars=yes,status=yes\')"><i></i></span>';
		innerHTML += ' <span class="icon-l i_ya" onclick="window.open(\'http://passport' + I_MAIN_DOMAIN + '/socialRedirectPoint/6/redirectToAuth/' + window.location.host + '\', \'_blank\', \'width=1024,height=400,resizable=yes,scrollbars=yes,status=yes\')"><i></i></span>';
		innerHTML += '</form></div>';
		ab.innerHTML = innerHTML;

		m = document.createElement('IFRAME');
		m.src = 'about:blank';
		m.id = 'FloatMask' + suf

		var h = document.body.offsetHeight + 'px';
		m.frameBorder = 0;
		//m.marginHeight = 0;
		//m.marginWidth = 0;
		m.allowTransparency = true;
		m.disabled = true;
		//m.canHaveChildren = false;
		//m.canHaveHTML = false;
		//m.innerHTML = null;
		m.datasrc = null;
		m.width = '100%';
		m.height = h;
		m.style.position = 'absolute';
		m.style.zIndex = 254;
		m.style.left = 0;
		m.style.top = 0;
		//m.style.border = 'none';
		m.style.opacity = '.75';
		m.style.filter = 'alpha(opacity = 75)';
		m.style.backgroundColor = '#FFFFFF';

		document.body.appendChild(m);
		document.body.appendChild(ab);

		ab.style.marginTop = (-ab.offsetHeight / 2) + 'px';
		ab.style.marginLeft = (-ab.offsetWidth / 2) + 'px';
	}

	if (act) {
		m.style.display = '';
		ab.style.display = '';
		if (url)
			document.forms.lFloat._url.value = url;
		if (suf == 'Login')
			setTimeout('document.forms.lFloat.login.focus();', 100);

		// i_updateSCode();
		// Autoload.call('hex_md5', '');
	} else {
		ab.style.display = 'none';
		m.style.display = 'none';
	}
	return false;
}

function i_lForm2(form)
{
	var c = new Date();
	var d = new Date(c.getTime() + 30*24*3600*1000);
	document.cookie='domn=' + form.domn.options[form.domn.selectedIndex].value + '; expires=' + d.toGMTString() + ';';
	return i_lForm(form);
}

function i_lForm(form)
{
	if (form.login.value.length < 1) {
		form.login.focus();
		return false;
	}
	if (form.pass.value.length < 1) {
		form.pass.focus();
		return false;
	}

	form._rand.value = Math.random();
	if (window.I_VER2 && !form._url.value)
		form._url.value = window.location.href;
//	var pass = form.pass.value;
//	if (!pass.match( /^\w+$/i ) || !form.scode || !window.hex_md5)
//		return true;
//
//	var crypt_pass = hex_md5(pass + form.scode.value);
//	form.cpass.value = crypt_pass;
//	form.pass.value = '';

	return true;
}

var i_blinkMail;
var i_blinkMailTimer;
var i_blinkMailStep;
function i_blinkM()
{
	if (!i_blinkMail) {
		i_blinkMail = document.getElementById('blinkMail');
		if (!i_blinkMail)
			return;
	}
	if (!i_blinkMailStep) {
		i_blinkMail.style.color='#778';
		i_blinkMailTimer = setTimeout(i_blinkM, 200);
	} else {
		i_blinkMail.style.color='#000';
		i_blinkMailTimer = setTimeout(i_blinkM, 1000);
	}

	i_blinkMailStep = !i_blinkMailStep;
}

var i_reqMail;
var i_chkEmlUrl = '//i.ua/check_mail.php';
function i_checkNewMail()
{
	if (!window.i_user)
		return;
	if (!i_blinkMail) {
		i_blinkMail = document.getElementById('blinkMail');
//		if (!i_blinkMail) {
//			clearInterval(i_checkInterval);
//			return;
//		}
	}
	if (!i_reqMail)
		i_reqMail = new Subsys_JsHttpRequest_Js();

	i_reqMail.onreadystatechange = function() {
		if (i_reqMail.readyState == 4 && i_reqMail.responseJS) {
			var count = i_reqMail.responseJS.unseen;
			if (count <= 0)
				count = 0;

			i_checkNewMailResponse(count);
		}
	}

	i_reqMail.caching = false;
	i_reqMail.open('GET', i_chkEmlUrl, true);
	i_reqMail.send({ user: window.i_user });
}
function i_checkNewMailResponse(count)
{
	var newMail = document.getElementById('newMail');
	var title = document.title.replace(/\[\d+\]$/, '');
	if (i_blinkMailTimer) {
		clearTimeout(i_blinkMailTimer);
		i_blinkMailTimer = null;
		i_blinkMail.style.color='#000';
	}
	if (count > 0) {
		var link = document.getElementById('dynamic-favicon') || document.createElement('link');
		link.type = 'image/x-icon';
		link.rel = 'shortcut icon';
		link.href = '//i3.i.ua/css/i2/favicon_new.ico';
		document.getElementsByTagName('head')[0].appendChild(link);
		document.title = title + '[' + count + ']';
		i_blinkM();
		var elem = newMail.getElementsByTagName('A')[0];
		elem.title = elem.title.replace(/: \d+$/, ': ' + count);
		elem = newMail.getElementsByTagName('IMG')[0];
		if (elem)
			elem.title = elem.title.replace(/: \d+$/, ': ' + count);
		elem = newMail.getElementsByTagName('I')[0];
		if (elem)
			elem.innerHTML = count;
		//newMail.style.display = '';
	} else {
		document.title = title;
		elem = newMail.getElementsByTagName('I')[0];
		if (elem)
			elem.innerHTML = '';
		//newMail.style.display = 'none';
	}
	if (i_blinkMail)
		i_blinkMail.title = i_blinkMail.title.replace(/: \d+$/, ': ' + count);

	if (window.i_msSiteModeJumpListIcon)
		i_msSiteModeJumpListIcon(count);
}

var i_checkInterval = setInterval(i_checkNewMail, 300000);

var i_reqSCode;
function i_updateSCode()
{
	if (!i_reqSCode)
		i_reqSCode = new Subsys_JsHttpRequest_Js();

	i_reqSCode.onreadystatechange = function() {
		if (i_reqSCode.readyState == 4) {
			var scode = i_reqSCode.responseJS.scode;

			var form;
			for (var i = 0; i < document.forms.length; i++) {
				form = document.forms[i];

				if (form.name != 'lFloat' && form.name != 'lform')
					continue;

				var inp = form.scode;
				if (!inp)
					continue;

//				alert(form.name + ' ' + inp.value + ' ' + scode);
				inp.value = scode;
			}
		}
	}

	i_reqSCode.caching = false;
	i_reqSCode.open('GET', window.I_SSL ? 'https://passport.i.ua/js/scode.js' : 'http://passport.i.ua/js/scode.js', true);
	i_reqSCode.send();
}

//var i_sCodeInterval = setInterval(i_updateSCode, 3600000);

function i_removeDefVal(input)
{
	input.value = '';
	input.onfocus = null;
}

function i_keypress(e)
{
	if (!e)
		e = event;

//	DBG(e);
//	return;

	var keyCode = e.keyCode;
	if (e.which)
		keyCode = e.which;
	var tag = '';
	if (e.srcElement)
		tag = e.srcElement.tagName;
	else if (e.target)
		tag = e.target.tagName;

//	alert(keyCode);
//	alert(e.ctrlKey);
//	alert(tag);
//	return;

	switch (keyCode) {
	case 13:
		if (!e.ctrlKey)
			break;
	case 10:
		break;

		var text = null;
		if (window.getSelection) {
//			alert('window.getSelection');
			text = window.getSelection();
		} else if (document.getSelection) {
//			alert('document.getSelection');
			text = document.getSelection();
		} else if (document.selection.createRange) {
//			alert('document.selection.createRange');
			text = document.selection.createRange().text;
		}
		text = String(text);
		if (text.length > 0) {
			if (text.length > 256) {
				alert('Выделите текст меньшего размера.')
			} else {
				if (confirm('Oшибка на странице:\n"' + text + '"\n\nОтослать сообщение об ошибке службе поддержки?\nВаш броузер останется на той же странице.')) {
					var fakedImage = document.createElement('IMG');
					fakedImage.src = 'http://i.ua/page_error.php?text=' + escape(text) + '&url=' + escape(document.location.href);
//					alert(fakedImage.src);
				}
			}
		}

		break;
	case 37:
	case 39:
		if (!e.ctrlKey || tag == 'INPUT' || tag == 'TEXTAREA' || tag == 'SELECT')
			break;

		var link = document.getElementById(keyCode == 37 ? 'prevLink' : 'nextLink');
		if (!link || !link.href)
			break;

		window.location.href = link.href;

		break;
	}
}

//if (!b || b.ie) {
//	document.onkeydown = i_keypress;
//} else {
//	if (document.attachEvent)
//		document.attachEvent('onkeydown', i_keypress);
//	else
//		document.addEventListener('keydown', i_keypress, false);
//}
if (window.UtilLite)
	UtilLite.addEvent(document, 'keydown', i_keypress);

function i_showSections()
{
//	alert('i_showSections');
	var allSec = document.getElementById('sections');
	if (!allSec)
		return;

	/*var cont = elem.parentNode.parentNode;
	var childs = cont.getElementsByTagName('LI');
//	alert(childs.length);
	for (var i = 1; i < childs.length; i++) {
		if (childs[i].className.match(/TopControl/)) // FIX! childs.length - 1
			continue;
		if (childs[i].className == 'last')
			continue;

		childs[i].style.display = childs[i].style.display == 'none' ? 'block' : 'none';
	}*/
//	alert(cont.tagName);

//	alert(allSec.style.display);
	allSec.style.display = allSec.style.display == 'block' ? 'none' : 'block';
	if ("undefined" != typeof HeaderMenu)
		HeaderMenu.toggleEditMode({force: 'close'});
}

// Shows menu with loading friends online
poToggledObjects = new Array(); // List of blocks on screen that were toggled off when showing peopleOnline
function i_showPeopleOnline()
{
	//if (window.I_VER2)
		//return i_showPeopleOnline2();

	var cell = dge('cellPeopleOnline');
	if (!cell)
		return;

	// Create Div for elements if needed
	var divInsert = dge('menuPeopleOnline');
	if (!divInsert) {

		// Find where to insert it
		var divAfter = cell.parentNode;
		while (divAfter && (divAfter.tagName != 'DIV'))
			 divAfter = divAfter.parentNode;
		if (!divAfter)
			return;

		// Compose element
		var divInsert = dce('DIV');
		divInsert.className = 'ho_popup ho_popup-chat';
		divInsert.id = 'menuPeopleOnline';

		divAfter.nextSibling ? divAfter.parentNode.insertBefore(divInsert, divAfter.nextSibling) : divAfter.parentNode.appendChild(divInsert);

		// Make "Loading..." state of control
		i_poSetLoading(divInsert);
	}

	// Remove flash/select/iframe and other objects underneath
	i_poHideBadObjects(divInsert);

	// Show element
	divInsert.style.display = 'block';

	// Update cell and switch
	//cell.className = 'calledExtended';

	var toggle = dge('togglePeopleOnline');
	if (toggle)
		toggle.onclick = i_closePeopleOnline;

	// Load people
	//lmCallAfterModulesReady(['PEOPLE_ONLINE'], i_poReady);
	Autoload.call(i_poReady, 'PeopleOnline');
}
//if (typeof(lmCallAfterModulesReady) == "undefined") {
//	function lmCallAfterModulesReady(modules, callee, param) {
//	}
//}

function i_showPeopleOnline2()
{
	var cell = dge('cellPeopleOnline');
	if (!cell)
		return;

	// Create Div for elements if needed
	var divInsert = dge('menuPeopleOnline');
	if (!divInsert) {

		// Find where to insert it
		var divAfter = cell.parentNode;

		// Compose element
		var divInsert = dce('DIV');
		divInsert.className = 'user_online';
		divInsert.id = 'menuPeopleOnline';

		divAfter.nextSibling ? divAfter.parentNode.insertBefore(divInsert, divAfter.nextSibling) : divAfter.parentNode.appendChild(divInsert);

		// Make "Loading..." state of control
		i_poSetLoading(divInsert); // FIX!
	}

	// Remove flash/select/iframe and other objects underneath
	i_poHideBadObjects(divInsert);

	// Show element
	divInsert.style.display = 'block';

	// Update cell and switch
	//cell.className = 'call_to_talk';

	var toggle = dge('togglePeopleOnline');
	if (toggle)
		toggle.onclick = i_closePeopleOnline2;

	// Load people
	Autoload.call(i_poReady, 'PeopleOnline');
}

// Sets 'Loading...' state to PeopleOnline control
// container is used just for optimization, can be undefined
function i_poSetLoading(container)
{
	if (window.I_VER2)
		return i_poSetLoading2(container);

		if (!container)
		container = dge('menuPeopleOnline');
	if (!container)
		return;

	// Localization
	var stLoading = 'Загрузка';
	switch (JS_LANG_ID) {
		case 2: {
			stLoading = 'Завантаження';
			break;
		}
		case 3: {
			stLoading = 'Loading';
			break;
		}
	}

	// Compose innerHTML
	var innerHTML = '<div class="l">&nbsp;</div>';
	innerHTML += '<p class="chatUsers">';
	innerHTML += '<div class="clear preload">' + stLoading + '&#133;</div>';
	innerHTML += '</p>';

	container.innerHTML = innerHTML;
}

function i_poSetLoading2(container) {
	if (!container)
		container = dge('menuPeopleOnline');
	if (!container)
		return;

	// Localization
	var stLoading = 'Загрузка';
	switch (JS_LANG_ID) {
		case 2: {
			stLoading = 'Завантаження';
			break;
		}
		case 3: {
			stLoading = 'Loading';
			break;
		}
	}

	// Compose innerHTML
	var innerHTML = '<div class="l">&nbsp;</div>';
	innerHTML += '<ins class="preloader"><i>' + stLoading + '&#133;</i></ins>';

	container.innerHTML = innerHTML;
}

// Hides bad objects (flash, SELECT and so on) that can interfere with listing of friends online container
function i_poHideBadObjects(container) {
	// If not visible - then toggle objects underneath and show
	var wasVisible = container.style.display == 'block';
	if (!wasVisible) {
		container.style.visibility = 'hidden';
		container.style.display = 'block';
	}

	var hiddenTags = ['SELECT','OBJECT','EMBED','IFRAME'];
	var objPos = getPosition(container);

	for (var i = 0; i < hiddenTags.length; i++)
		poToggledObjects = poToggledObjects.concat(toggleDisplay(hiddenTags[i], 'hidden', null, objPos));

	if (!wasVisible) {
		container.style.visibility = 'visible';
		container.style.display = 'none';
	}
}

// Reaction on pOnline object loaded
function i_poReady () {
	po_checkStart();
}

// Hides block of online people. Used only when managing class was not loaded still, because will be overwritten by it later.
function i_closePeopleOnline()
{
	if (window.I_VER2)
		return i_closePeopleOnline2();

	// Hide block
	var block = dge('menuPeopleOnline');
	if (block)
		block.style.display = 'none';

	// Show toggled objects
	for (var i = 0; i < poToggledObjects.length; i++)
		poToggledObjects[i].style.visibility = 'visible';
	poToggledObjects = new Array();

	// Update cell and switch
	/*var cell = dge('cellPeopleOnline');
	if (cell)
		cell.className = 'callExtended';*/

	var toggle = dge('togglePeopleOnline');
	if (toggle)
		toggle.onclick = i_showPeopleOnline;
}

function i_closePeopleOnline2() {
	// Hide block
	var block = dge('menuPeopleOnline');
	if (block)
		block.style.display = 'none';

	// Show toggled objects
	for (var i = 0; i < poToggledObjects.length; i++)
		poToggledObjects[i].style.visibility = 'visible';
	poToggledObjects = new Array();

	// Update cell and switch
	/*var cell = dge('cellPeopleOnline');
	if (cell)
		cell.className = '';*/

	var toggle = dge('togglePeopleOnline');
	if (toggle)
		toggle.onclick = i_showPeopleOnline2;
}

function i_getBottomPos()
{
	if (window.innerWidth) {// ff & opera
		WH = window.innerHeight;
		pixelTop = window.pageYOffset;
	} else if (document.documentElement && document.documentElement.clientWidth) {// ie
		WH = document.documentElement.clientHeight;
		pixelTop = document.documentElement.scrollTop;
	} else if (document.body) {
		WH = document.body.clientHeight;
		pixelTop = document.body.scrollTop
	}
	if (!bottomVisible && WH + pixelTop > bottomBannerHeight) {
		bottomVisible = true;
		if (typeof(viewAdsUrl)!='undefined') {
			tmp = new Image();
			tmp.src=viewAdsUrl;
		}
		window.onscroll = null;
		window.onresize = null;
	}
}

function i_s(ru, ua, en, al)
{
	if (Object.prototype.toString.call(ru) === "[object Array]")
		return i_s.apply(this, ru);
	switch (window.JS_LANG_ID) {
	case 2: return ua || ru;
	case 3: return en || ru;
	case 4: return al || ru;
	}
	return ru;
}

function bannerInternalFooterJS()
{
	var offsets = getPosition(dge('bottomBanners'));
	bottomBannerHeight = offsets['y'];
	bottomVisible = 0;
	i_getBottomPos();
	if (!bottomVisible) {
		UtilLite.addEvent(window, 'scroll', i_getBottomPos);
		UtilLite.addEvent(window, 'resize', i_getBottomPos);
	}
}

function i_checkOpenstat(val)
{
	var img = dce('IMG');
	img.src = 'http://passport.i.ua/redirect/?_openstat=' + val;
}
function i_closeDisclaimer(el)
{
	el.parentNode.style.display='none'
	var img = dce("IMG");
	img.src = "http://i.ua/sc.php?name=disclaimer&value=1&expire=315360000&_rand=" + Math.random();
}
