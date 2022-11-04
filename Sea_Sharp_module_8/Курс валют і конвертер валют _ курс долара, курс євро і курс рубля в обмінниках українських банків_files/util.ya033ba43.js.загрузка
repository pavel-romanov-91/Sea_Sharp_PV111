function browseIt()
{
	this.ver = navigator.appVersion.toLowerCase();
	this.verNum = parseInt(this.ver);
	this.agent = navigator.userAgent.toLowerCase();
	this.dom = (document.getElementById ? 1 : 0);
	this.opera = (this.agent.indexOf("opera") > -1 && this.dom ? 1 : 0);
	this.opera7 = (this.opera && this.verNum >= 7);
	this.opera9 = (this.opera && this.verNum >= 9);
	this.ie11 = window.navigator.appName == 'Netscape' && (new RegExp("Trident/.*rv:([0-9]{1,}[\.0-9]{0,})").exec(window.navigator.userAgent) != null);
	this.ie = ((this.ver.indexOf("msie") > -1 /*|| (this.ie11)*/) && this.dom && !this.opera ? 1 : 0);// according to ms we shouldn't detect b.ie if it is ie11
	this.webkit = this.ver.indexOf("applewebkit") > -1;
	this.chrome = this.ver.indexOf("chrome") > -1;
	this.safari = this.chrome ? false : this.ver.indexOf("safari") > -1;
	this.ieVer = 0;
	if (this.ie) {
		var pos = this.ver.indexOf("msie");
		if (pos != -1)
			this.ieVer = parseFloat(this.ver.substr(pos + 5));
	}
	this.ie6 = (this.ie && (this.ieVer >= 6));
	this.ie6only = (this.ie && (this.ieVer >= 6) && (this.ieVer < 7));
	this.ie7 = (this.ie && (this.ieVer >= 7));
	this.ie8 = (this.ie && (this.ieVer >= 8));
	this.ie9 = (this.ie && (this.ieVer >= 9));
	if (this.ie11 && this.ieVer == 0) {
		this.ieVer = 11;
	}
	this.macOS = (this.agent.indexOf("mac") > -1);
	this.mac = (this.macOS && this.verNum >= 7 ? 1 : 0);
	this.moz = (this.agent.indexOf("gecko") > -1);
	if(this.ie11) {
		this.moz = 0;
	}
	this.ns6 = (this.dom && this.agent.indexOf("netscape") > -1 && this.verNum >= 5 ? 1 : 0);
	this.ff = (this.agent.indexOf("firefox") > -1);
	this.b = (this.ie || this.ns6 || this.opera7 || this.mac || this.moz || this.dom);

	return this;
}

//var px = window.opera ? "" : "px";
var b = new browseIt();


function trim(s, p)
{
	if (typeof s != 'string')
		return s;

	return s.replace(p ? p : /^\s*|\s*$/g, '');
}

function stripTags(str)
{
	return str.replace(/(<([^>]*)>)/g, '');
}

function checkAll(val, p)
{
	if (typeof p == 'string')
		p = document.getElementById(p);
	if (!p)
		p = document.body;

	var arr = p.getElementsByTagName('INPUT');
	for (var i = 0; i < arr.length; i++) {
		if (arr[i].type == 'checkbox')
			arr[i].checked = val;
	}
}

function checkDate(month, day, year)
{
	if (month < 1 || month > 12) return false;
	if (day < 1 || day > 31) return false;
	switch (month) {
	case 4:
	case 6:
	case 9:
	case 11:
		if (day > 30) return false;
		break;
	case 2:
		if (year % 4) {
			if (day > 28) return false;
		} else {
			if (day > 29) return false;
		}
		break;
	}

	return true;
}

function frPr()
{
	if (parent && parent != window)
		parent.location.href = window.location.href;
}

// Tag is either tagName or list of elements to apply effect to
// tag - either TAG or Array of elements to toggle
// visibleValue - 'hidden' or 'visible' to set to toggled object style.visibility
// cont - deprecated, not used any more, can be undefined
// dims - element dimensions (x, y, w, h record) - if defined, then only elements under this dimensions will be toggled
var toggleDisplay_hiddenObj = [];
function toggleDisplay(tag, visibleValue, cont_depriciated, dims)
{
	var isHide = (visibleValue == 'hidden');

	// Is it tag name or array of elements
	var sel = [ ];
	if (typeof(tag) == 'string') {
		if (!isHide) {
			var tmp = [ ];
			for (var i = 0; i < toggleDisplay_hiddenObj.length; i++) {
				if (toggleDisplay_hiddenObj[i].tagName == tag)
					sel.push(toggleDisplay_hiddenObj[i]);
				else
					tmp.push(toggleDisplay_hiddenObj[i]);
			}
			toggleDisplay_hiddenObj = tmp;
			//alert([tag, sel.length, toggleDisplay_hiddenObj.length]);
		} else {
			sel = document.getElementsByTagName(tag);
		}
	} else {
		sel = tag;
	}
//	var sel = (tag.charAt) ? document.getElementsByTagName(tag) : tag;
	var changedObj = [];

	var b = null;
	for (var i = 0; i < sel.length; i++) {
		var obj = sel[i];

		// Check that we need to change value to 'hidden' and add object to list as hidden by us
		if (isHide && (obj.style.visibility == 'hidden'  || obj.parentNode.style.visibility == 'hidden'))
			continue;

		// Check that object within our borders
		if (dims) {
			b = getPosition(obj);
			if (!((((dims.x > b.x && dims.x < (b.x+b.w)) || ((dims.x+dims.w) > b.x && (dims.x+dims.w) < (b.x+b.w))) && ((dims.y > b.y && dims.y < (b.y+b.h)) || ((dims.y+dims.h) > b.y && (dims.y+dims.h) < (b.y+b.h)))) || (((b.x > dims.x && b.x < (dims.x+dims.w)) || ((b.x+b.w) > dims.x && (b.x+b.w) < (dims.x+dims.w))) && ((b.y > dims.y && b.y < (dims.y+dims.h)) || ((b.y+b.h) > dims.y && (b.y+b.h) < (dims.y+dims.h))))))
				continue;
		}

		obj.style.visibility = visibleValue;
		changedObj.push(obj);
		if (isHide)
			toggleDisplay_hiddenObj.push(obj);
	}
	return changedObj;
}

// Aliases
/**
  * function dce(tagName)
  * @returns {Element}
 */
function dce(tag) {
	return document.createElement(tag);
}
/**
  * function dce(tagName)
  * @returns {Text}
 */
function dct(text) {
	return document.createTextNode(text);
}
/**
  * function dge(tagName)
  * @returns {Element}
 */
function dge(id) {
	return document.getElementById(id);
}

// Searches items in array with geiven property equal to searchVal
function getItemIndex(searchVal, indexCompare, arr) {
	var len = arr.length;
	for (var i = 0; i < len; i++) {
		if (arr[i][indexCompare] == searchVal) {
			return i;
		}
	}
	return -1;
}

// Searches array for element
function arrayPos(element, arr) {
	var len = arr.length;
	for (var i = 0; i < len; i++) {
		if (arr[i] == element) {
			return i;
		}
	}
	return -1;
}

// Util func - clears elements in container and destroys circular reference links
function peUtilClearContainer(container) {
	if (typeof(container.childNodes) != 'undefined') {
		while (container.childNodes.length) {
			if (typeof(container.firstChild.controller) != 'undefined')
				container.firstChild.controller = null;
			peUtilClearContainer(container.firstChild);
			var tmp = container.firstChild;
			container.removeChild(tmp);
			tmp = null;
			delete tmp;
		}
	}
}

// Compares str1 with str2, returns -1 (str1 lower), 0 (equal), +1 (str1 bigger)
function strCmp(str1, str2) {
	if (str1 == str2)
		return 0;
	var arr = new Array(str1, str2);
	arr.sort();
	if (arr[0] == str1)
		return -1;
	else
		return 1;
}

// Compares str1 with str2, returns -1 (str1 lower), 0 (equal), +1 (str1 bigger)
function striCmp(str1, str2) {
	str1 = '' + str1;
	str2 = '' + str2;
	if (str1 == str2)
		return 0;
	str1 = str1.toLowerCase();
	str2 = str2.toLowerCase();
	var arr = new Array(str1, str2);
	arr.sort();
	if (arr[0] == str1)
		return -1;
	else
		return 1;
}

function DBG(elem)
{
	var str = '';

	for (var i in elem) {
		str += i + ': ' + elem[i] + '; ';
	}

	alert(str)
}

// Alerts number of times
nalertCount = 0;
function nalert(st, max) {
	if (nalertCount < max) {
		alert(st);
		nalertCount++;
	}
}

// Formats string to be safe for GET method
function formatStToSafeGET(st) {
	st = '' + st;
	st = st.replace(/%/g, '%25');
	st = st.replace(/\+/g, '%2B');
	st = st.replace(/ /g, '+');
	st = st.replace(/\?/g, '%3F');
	st = st.replace(/&/g, '%26');
	st = st.replace(/=/g, '%3D');
	st = st.replace(/'/g, '%27'); // st = st.replace(/'/, '%27'); comment for editor highlighting
	st = st.replace(/"/g, '%22'); // st = st.replace(/"/, '%22'); comment for editor highlighting
	st = st.replace(/\//g, '%2F');
	st = st.replace(/\\/g, '%5C');
	st = st.replace(/\x0d/g, '%0D');
	st = st.replace(/\x0a/g, '%0A');
	return st;
}

function inputLimit(input, maxlen, left)
{
	inputstr = input.value;
	strlen = inputstr.length;
	if (strlen > maxlen)
		input.value = inputstr.substring(0, maxlen);
	if (left)
		left = document.getElementById(left);
	if (left) {
		if (left.tagName == 'INPUT')
			left.value = maxlen - input.value.length;
		else
			left.innerHTML = maxlen - input.value.length;
	}
	return true;
}

function getPosition(elem, checkScroll)
{
	if (typeof(checkScroll) == 'undefined')
		checkScroll = false;

	var left = 0;
	var top  = 0;
	var width = elem.offsetWidth;
	var height = elem.offsetHeight;

	while (elem.offsetParent){
		left += elem.offsetLeft;
		top += elem.offsetTop;
		if (checkScroll) {
			left -= elem.scrollLeft;
			top -= elem.scrollTop;
		}
		elem = elem.offsetParent;
	}

	left += elem.offsetLeft;
	top += elem.offsetTop;

	return { x: left, y: top, w: width, h: height };
}
function getPosition2(elem, checkScroll)
{
	if (elem.getBoundingClientRect)
    	return getOffsetRect(elem);
	else
		return getPosition(elem, checkScroll);
}
function getOffsetRect(elem) {
	var width = elem.offsetWidth;
	var height = elem.offsetHeight;
	var box = elem.getBoundingClientRect();
	var body = document.body;
	var docElem = document.documentElement;
	var scrollTop = window.pageYOffset || docElem.scrollTop || body.scrollTop;
	var scrollLeft = window.pageXOffset || docElem.scrollLeft || body.scrollLeft;
	var clientTop = docElem.clientTop || body.clientTop || 0;
	var clientLeft = docElem.clientLeft || body.clientLeft || 0;
	var top  = box.top +  scrollTop - clientTop;
	var left = box.left + scrollLeft - clientLeft;
	return { x: Math.round(left), y: Math.round(top), w: width, h: height };
}
function mouseCoords(evt)
{
	evt = evt || window.event;
	if (evt.pageX || evt.pageY) {
		return { x: evt.pageX, y: evt.pageY };
	}
	if (b.ie && b.ieVer >= 6)
		return {
			x: evt.clientX + document.documentElement.scrollLeft - document.documentElement.clientLeft,
			y: evt.clientY + document.documentElement.scrollTop  - document.documentElement.clientTop
		};
	else
		return {
			x: evt.clientX + document.body.scrollLeft - document.body.clientLeft,
			y: evt.clientY + document.body.scrollTop  - document.body.clientTop
		};
}

// Returns current info about browser info - scrolling offsets, width and height
function getWindowInfo()
{
	var ieStyle = document.documentElement && (typeof(document.documentElement.scrollLeft) != 'undefined');

	// Offsets
	var scrOfX = 0, scrOfY = 0;
	if (typeof(window.pageYOffset) == 'number') {
		//Netscape compliant
		scrOfY = window.pageYOffset;
		scrOfX = window.pageXOffset;
	} else if (document.body && (typeof(document.body.scrollLeft) != 'undefined') && !ieStyle) {
		//DOM compliant
		scrOfY = document.body.scrollTop;
		scrOfX = document.body.scrollLeft;
	} else if (ieStyle) {
		//IE6 standards compliant mode
		scrOfY = document.documentElement.scrollTop;
		scrOfX = document.documentElement.scrollLeft;
	}
	// Width and height
	var myWidth = 0, myHeight = 0;
	if( typeof( window.innerWidth ) == 'number' ) {
		//Non-IE
		myWidth = window.innerWidth;
		myHeight = window.innerHeight;
	} else if( document.documentElement && (typeof(document.documentElement.clientWidth) != 'undefined')) {
		//IE 6+ in 'standards compliant mode'
		myWidth = document.documentElement.clientWidth;
		myHeight = document.documentElement.clientHeight;
	} else if( document.body && (typeof(document.body.clientWidth) != 'undefined') ) {
		//IE 4 compatible
		myWidth = document.body.clientWidth;
		myHeight = document.body.clientHeight;
	}
	return {top: scrOfY, left: scrOfX, width: myWidth, height: myHeight};
}

// Returns right form for spelling "$num items", where $form = ('предмет', 'предмета', 'предметов')
function itemSpelling(num, form){
	switch (num % 10) {
		case 1:
			if (num % 100 != 11)
				return form[0];
		case 2:
		case 3:
		case 4:
			if (num % 100 < 11 || num % 100 > 14)
				return form[1];
		default:
			return form[2];
	}
}

// Adds element to document.body, when exact position is not important for us (for hidden of floating elements)
// Safe for use in IE
function addToBody(element) {
	if (document.body.firstChild)
		document.body.insertBefore(element, document.body.firstChild);
	else
		document.body.appendChild(element);
}

// Returns string ready to be put in innerHTML
// Notice: this func is used in such ways that it must preserve all symbols of "\r\n" spaces and tabs even in end of strings
function util_htmlspecialchars(st) {
	if (!this.regAmp) {
		// For optimization create regexps
		this.regAmp = /&/g;
		this.regLt = /</g;
		this.regGt = />/g;
		this.regQuot = /"/g; 		// "
	}

	// Order is important!
	var result = st + '';
	var result = result.replace(this.regAmp, '&amp;');
	result = result.replace(this.regLt, '&lt;');
	result = result.replace(this.regGt, '&gt;');
	result = result.replace(this.regQuot, '&quot;');

	return result;
}

function sprintf(str, arg){
	str = str + '';
	var arg = arg || [];
	var re = /%s/;
	for (var i = 0; i<arg.length; i++)
		str = str.replace(re, arg[i]);
	return str;
}

// Sets cookie for user
// expires can be either date or delta from current time
function utilSetCookie(name, value, expires, path, domain, secure)
{
	var expiresString = null;
	if (expires) {
		if (typeof(expires.getTime) == 'undefined') {
			// Delta in milliseconds
			var date = new Date();
			date.setTime(date.getTime() + expires);
			expiresString = date.toGMTString();
		} else {
			expiresString = expires.toGMTString();
		}
	}

	// Set cookie
	document.cookie = escape(name) + '=' + escape(value)
	+ (expiresString ? '; expires=' + expiresString : '')
	+ (path ? '; path=' + path : '; path=/')
	+ (domain ? '; DOMAIN=' + domain : '')
	+ (secure ? '; SECURE' : '');
}

function utilGetCookie(name) {
  var matches = document.cookie.match(new RegExp(
    '(?:^|; )' + name.replace(/([\.$?*|{}\(\)\[\]\\\/\+^])/g, '\\$1') + '=([^;]*)'
  ));
  return matches ? decodeURIComponent(matches[1]) : undefined;
}

function hrefSSG()
{
	return window.SSG ? '&SSG=' + window.SSG : '';
}

// Notifiers
UTIL_LOADED = true;
UTIL_READY = true;

var UtilLite = { };

UtilLite.addEvent = function (object, eventType, func)
{
	object[/*@cc_on !@*/0 ? 'attachEvent' : 'addEventListener'](/*@cc_on 'on' + @*/eventType, func, false);
}

UtilLite.removeEvent = function (object, eventType, func)
{
	object[/*@cc_on !@*/0 ? 'detachEvent' : 'removeEventListener'](/*@cc_on 'on' + @*/eventType, func, false);
}

UtilLite.addEventDOMLoaded = function (func)
{
	/* Mozilla/Firefox/Opera 9 */
	if (document.addEventListener) {
		document.addEventListener("DOMContentLoaded", func, false);
		return;
	}

	/* Internet Explorer */
	/*@cc_on @*/
	/*@if (@_win32)
	document.write('<scr' + 'ipt id="__ie_onloadA" defer="defer" src="javascript:void(0)"></s' + 'cript>');
	var scr = dge("__ie_onloadA");
	scr.onreadystatechange = function() {
		if (/loaded|complete/.test(this.readyState)) {
			this.onreadystatechange = null;
	        window.setTimeout(func, 10);
		}
	};
	/*@end @*/

	/* Safari */
	if (/WebKit/i.test(navigator.userAgent)) {
		var _tmr = setInterval(function() {
			if (/loaded|complete/.test(document.readyState)) {
				clearInterval(_tmr);
				func();
			}
		}, 10);
	}
}