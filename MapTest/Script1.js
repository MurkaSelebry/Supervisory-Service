//// JavaScript source code
var geocode = ymaps.geocode('������ ��������', {
    /**
     * ����� �������
     * @see https://api.yandex.ru/maps/doc/jsapi/2.1/ref/reference/geocode.xml
     */
    // ���������� ����������� �� ������ ���� �����.
    // boundedBy: myMap.getBounds(),
    // strictBounds: true,
    // ������ � ������ boundedBy ����� ������ ������ ������ �������, ��������� � boundedBy.
    // ���� ����� ������ ���� ���������, �������� ������ �������������.
    results: 1
}).then(function (res) {
    // �������� ������ ��������� ��������������.
    var firstGeoObject = res.geoObjects.get(0),
        // ���������� ����������.
        coords = firstGeoObject.geometry.getCoordinates(),
        // ������� ��������� ����������.
        bounds = firstGeoObject.properties.get('boundedBy');

    firstGeoObject.options.set('preset', 'islands#darkBlueDotIconWithCaption');
    // �������� ������ � ������� � ������� � ������ ����������.
    firstGeoObject.properties.set('iconCaption', firstGeoObject.getAddressLine());

    // ��������� ������ ��������� ��������� �� �����.
    myMap.geoObjects.add(firstGeoObject);
    // ������������ ����� �� ������� ��������� ����������.
    myMap.setBounds(bounds, {
        // ��������� ������� ������ �� ������ ��������.
        checkZoomRange: true
    });

    /**
     * ��� ������ � ���� javascript-�������.
     */
    console.log('��� ������ ����������: ', firstGeoObject.properties.getAll());
    /**
     * ���������� ������� � ������ ���������.
     * @see https://api.yandex.ru/maps/doc/geocoder/desc/reference/GeocoderResponseMetaData.xml
     */
    console.log('���������� ������ ���������: ', res.metaData);
    /**
     * ���������� ���������, ������������ ��� ���������� �������.
     * @see https://api.yandex.ru/maps/doc/geocoder/desc/reference/GeocoderMetaData.xml
     */
    console.log('���������� ���������: ', firstGeoObject.properties.get('metaDataProperty.GeocoderMetaData'));
    /**
     * �������� ������ (precision) ������������ ������ ��� �����.
     * @see https://api.yandex.ru/maps/doc/geocoder/desc/reference/precision.xml
     */
    console.log('precision', firstGeoObject.properties.get('metaDataProperty.GeocoderMetaData.precision'));
    /**
     * ��� ���������� ������� (kind).
     * @see https://api.yandex.ru/maps/doc/geocoder/desc/reference/kind.xml
     */
    console.log('��� ����������: %s', firstGeoObject.properties.get('metaDataProperty.GeocoderMetaData.kind'));
    console.log('�������� �������: %s', firstGeoObject.properties.get('name'));
    console.log('�������� �������: %s', firstGeoObject.properties.get('description'));
    console.log('������ �������� �������: %s', firstGeoObject.properties.get('text'));
    /**
    * ������ ������ ��� ������ � ������������ ��������������.
    * @see https://tech.yandex.ru/maps/doc/jsapi/2.1/ref/reference/GeocodeResult-docpage/#getAddressLine
    */
    console.log('\n�����������: %s', firstGeoObject.getCountry());
    console.log('���������� �����: %s', firstGeoObject.getLocalities().join(', '));
    console.log('����� �������: %s', firstGeoObject.getAddressLine());
    console.log('������������ ������: %s', firstGeoObject.getPremise() || '-');
    console.log('����� ������: %s', firstGeoObject.getPremiseNumber() || '-');

    /**
     * ���� ����� �������� �� ��������� ���������� ����������� ����� �� ������ ������� � ��������� ������, ������� ����� ����� �� ����������� ��������� � ��������� �� �� ����� ������ ���������.
     */
    /**
     var myPlacemark = new ymaps.Placemark(coords, {
     iconContent: '��� �����',
     balloonContent: '���������� ������ <strong>���� �����</strong>'
     }, {
     preset: 'islands#violetStretchyIcon'
     });

     myMap.geoObjects.add(myPlacemark);
     */
});
ymaps.ready(init);
function init() {
    var myMap = new ymaps.Map('map', {
        center: [55.74, 37.58],
        zoom: 13,
        controls: []
    });
}