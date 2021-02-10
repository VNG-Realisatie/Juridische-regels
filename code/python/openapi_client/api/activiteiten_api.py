"""
    Plan SW - Toepasbare regel SW

    Nog in te voorzien  # noqa: E501

    The version of the OpenAPI document: 0.0.1
    Contact: robert.melskens@vng.nl
    Generated by: https://openapi-generator.tech
"""


import re  # noqa: F401
import sys  # noqa: F401

from openapi_client.api_client import ApiClient, Endpoint as _Endpoint
from openapi_client.model_utils import (  # noqa: F401
    check_allowed_values,
    check_validations,
    date,
    datetime,
    file_type,
    none_type,
    validate_and_convert_types
)
from openapi_client.model.activiteit_hal import ActiviteitHal
from openapi_client.model.activiteit_hal_collectie import ActiviteitHalCollectie
from openapi_client.model.bad_request_foutbericht import BadRequestFoutbericht
from openapi_client.model.foutbericht import Foutbericht


class ActiviteitenApi(object):
    """NOTE: This class is auto generated by OpenAPI Generator
    Ref: https://openapi-generator.tech

    Do not edit the class manually.
    """

    def __init__(self, api_client=None):
        if api_client is None:
            api_client = ApiClient()
        self.api_client = api_client

        def __getactiviteit(
            self,
            identificatie,
            **kwargs
        ):
            """getactiviteit  # noqa: E501

            <body><p>Het bericht dat de JSON/REST API voor het ophalen van gegevens van een amendement retourneert.</p></body>  # noqa: E501
            This method makes a synchronous HTTP request by default. To make an
            asynchronous HTTP request, please pass async_req=True

            >>> thread = api.getactiviteit(identificatie, async_req=True)
            >>> result = thread.get()

            Args:
                identificatie (str): <body><p>De unieke identificatie waaronder elk object van dit type bekend is.</p></body>

            Keyword Args:
                expand (str): Hiermee kun je opgeven welke gerelateerde resources meegeleverd moeten worden, en hun inhoud naar behoefte aanpassen. Hele resources of enkele properties geef je in de expand parameter kommagescheiden op. Properties die je wil ontvangen geef je op met de resource-naam gevolgd door de property naam, met daartussen een punt. In de definitie van het antwoord kun je bij _embedded zien welke gerelateerde resources meegeleverd kunnen worden. Zie [functionele specificaties](https://github.com/VNG-Realisatie/Haal-Centraal-common/blob/v1.2.0/features/expand.feature).. [optional]
                inclusiefvervallen (bool): <body><p>Als de parameter 'vanafdatum' een waarde heeft dan moet een evt. waarde van dit attribute worden genegeerd.</p></body>. [optional]
                vanafdatum (date): [optional]
                _return_http_data_only (bool): response data without head status
                    code and headers. Default is True.
                _preload_content (bool): if False, the urllib3.HTTPResponse object
                    will be returned without reading/decoding response data.
                    Default is True.
                _request_timeout (float/tuple): timeout setting for this request. If one
                    number provided, it will be total request timeout. It can also
                    be a pair (tuple) of (connection, read) timeouts.
                    Default is None.
                _check_input_type (bool): specifies if type checking
                    should be done one the data sent to the server.
                    Default is True.
                _check_return_type (bool): specifies if type checking
                    should be done one the data received from the server.
                    Default is True.
                _host_index (int/None): specifies the index of the server
                    that we want to use.
                    Default is read from the configuration.
                async_req (bool): execute request asynchronously

            Returns:
                ActiviteitHal
                    If the method is called asynchronously, returns the request
                    thread.
            """
            kwargs['async_req'] = kwargs.get(
                'async_req', False
            )
            kwargs['_return_http_data_only'] = kwargs.get(
                '_return_http_data_only', True
            )
            kwargs['_preload_content'] = kwargs.get(
                '_preload_content', True
            )
            kwargs['_request_timeout'] = kwargs.get(
                '_request_timeout', None
            )
            kwargs['_check_input_type'] = kwargs.get(
                '_check_input_type', True
            )
            kwargs['_check_return_type'] = kwargs.get(
                '_check_return_type', True
            )
            kwargs['_host_index'] = kwargs.get('_host_index')
            kwargs['identificatie'] = \
                identificatie
            return self.call_with_http_info(**kwargs)

        self.getactiviteit = _Endpoint(
            settings={
                'response_type': (ActiviteitHal,),
                'auth': [],
                'endpoint_path': '/activiteiten/{identificatie}',
                'operation_id': 'getactiviteit',
                'http_method': 'GET',
                'servers': None,
            },
            params_map={
                'all': [
                    'identificatie',
                    'expand',
                    'inclusiefvervallen',
                    'vanafdatum',
                ],
                'required': [
                    'identificatie',
                ],
                'nullable': [
                ],
                'enum': [
                ],
                'validation': [
                ]
            },
            root_map={
                'validations': {
                },
                'allowed_values': {
                },
                'openapi_types': {
                    'identificatie':
                        (str,),
                    'expand':
                        (str,),
                    'inclusiefvervallen':
                        (bool,),
                    'vanafdatum':
                        (date,),
                },
                'attribute_map': {
                    'identificatie': 'identificatie',
                    'expand': 'expand',
                    'inclusiefvervallen': 'inclusiefvervallen',
                    'vanafdatum': 'vanafdatum',
                },
                'location_map': {
                    'identificatie': 'path',
                    'expand': 'query',
                    'inclusiefvervallen': 'query',
                    'vanafdatum': 'query',
                },
                'collection_format_map': {
                }
            },
            headers_map={
                'accept': [
                    'application/hal+json',
                    'application/problem+json'
                ],
                'content_type': [],
            },
            api_client=api_client,
            callable=__getactiviteit
        )

        def __getactiviteiten(
            self,
            **kwargs
        ):
            """getactiviteiten  # noqa: E501

            <body><p>Het bericht dat de JSON/REST API voor het ophalen van een collectie amendementen retourneert.</p></body>  # noqa: E501
            This method makes a synchronous HTTP request by default. To make an
            asynchronous HTTP request, please pass async_req=True

            >>> thread = api.getactiviteiten(async_req=True)
            >>> result = thread.get()


            Keyword Args:
                page (int): Een pagina binnen de gepagineerde resultatenset.. [optional]
                expand (str): Hiermee kun je opgeven welke gerelateerde resources meegeleverd moeten worden, en hun inhoud naar behoefte aanpassen. Hele resources of enkele properties geef je in de expand parameter kommagescheiden op. Properties die je wil ontvangen geef je op met de resource-naam gevolgd door de property naam, met daartussen een punt. In de definitie van het antwoord kun je bij _embedded zien welke gerelateerde resources meegeleverd kunnen worden. Zie [functionele specificaties](https://github.com/VNG-Realisatie/Haal-Centraal-common/blob/v1.2.0/features/expand.feature).. [optional]
                begindatum (date): [optional]
                bovenliggendeactiviteitidentificatie (str): [optional]
                einddatum (date): [optional]
                gerelateerdeactiviteitidentificaties (str): [optional]
                inclusiefvervallen (bool): <body><p>Als de parameter 'vanafdatum' een waarde heeft dan moet een evt. waarde van dit attribute worden genegeerd.</p></body>. [optional]
                juridischeregelvooriedereenidentificaties (str): [optional]
                laatstewijzigingsdatum (date): [optional]
                naam (str): <body><p>Een (korte) omschrijving van de activiteit.</p></body>. [optional]
                vanafdatum (date): [optional]
                _return_http_data_only (bool): response data without head status
                    code and headers. Default is True.
                _preload_content (bool): if False, the urllib3.HTTPResponse object
                    will be returned without reading/decoding response data.
                    Default is True.
                _request_timeout (float/tuple): timeout setting for this request. If one
                    number provided, it will be total request timeout. It can also
                    be a pair (tuple) of (connection, read) timeouts.
                    Default is None.
                _check_input_type (bool): specifies if type checking
                    should be done one the data sent to the server.
                    Default is True.
                _check_return_type (bool): specifies if type checking
                    should be done one the data received from the server.
                    Default is True.
                _host_index (int/None): specifies the index of the server
                    that we want to use.
                    Default is read from the configuration.
                async_req (bool): execute request asynchronously

            Returns:
                ActiviteitHalCollectie
                    If the method is called asynchronously, returns the request
                    thread.
            """
            kwargs['async_req'] = kwargs.get(
                'async_req', False
            )
            kwargs['_return_http_data_only'] = kwargs.get(
                '_return_http_data_only', True
            )
            kwargs['_preload_content'] = kwargs.get(
                '_preload_content', True
            )
            kwargs['_request_timeout'] = kwargs.get(
                '_request_timeout', None
            )
            kwargs['_check_input_type'] = kwargs.get(
                '_check_input_type', True
            )
            kwargs['_check_return_type'] = kwargs.get(
                '_check_return_type', True
            )
            kwargs['_host_index'] = kwargs.get('_host_index')
            return self.call_with_http_info(**kwargs)

        self.getactiviteiten = _Endpoint(
            settings={
                'response_type': (ActiviteitHalCollectie,),
                'auth': [],
                'endpoint_path': '/activiteiten',
                'operation_id': 'getactiviteiten',
                'http_method': 'GET',
                'servers': None,
            },
            params_map={
                'all': [
                    'page',
                    'expand',
                    'begindatum',
                    'bovenliggendeactiviteitidentificatie',
                    'einddatum',
                    'gerelateerdeactiviteitidentificaties',
                    'inclusiefvervallen',
                    'juridischeregelvooriedereenidentificaties',
                    'laatstewijzigingsdatum',
                    'naam',
                    'vanafdatum',
                ],
                'required': [],
                'nullable': [
                ],
                'enum': [
                ],
                'validation': [
                    'page',
                ]
            },
            root_map={
                'validations': {
                    ('page',): {

                        'inclusive_minimum': 1,
                    },
                },
                'allowed_values': {
                },
                'openapi_types': {
                    'page':
                        (int,),
                    'expand':
                        (str,),
                    'begindatum':
                        (date,),
                    'bovenliggendeactiviteitidentificatie':
                        (str,),
                    'einddatum':
                        (date,),
                    'gerelateerdeactiviteitidentificaties':
                        (str,),
                    'inclusiefvervallen':
                        (bool,),
                    'juridischeregelvooriedereenidentificaties':
                        (str,),
                    'laatstewijzigingsdatum':
                        (date,),
                    'naam':
                        (str,),
                    'vanafdatum':
                        (date,),
                },
                'attribute_map': {
                    'page': 'page',
                    'expand': 'expand',
                    'begindatum': 'begindatum',
                    'bovenliggendeactiviteitidentificatie': 'bovenliggendeactiviteitidentificatie',
                    'einddatum': 'einddatum',
                    'gerelateerdeactiviteitidentificaties': 'gerelateerdeactiviteitidentificaties',
                    'inclusiefvervallen': 'inclusiefvervallen',
                    'juridischeregelvooriedereenidentificaties': 'juridischeregelvooriedereenidentificaties',
                    'laatstewijzigingsdatum': 'laatstewijzigingsdatum',
                    'naam': 'naam',
                    'vanafdatum': 'vanafdatum',
                },
                'location_map': {
                    'page': 'query',
                    'expand': 'query',
                    'begindatum': 'query',
                    'bovenliggendeactiviteitidentificatie': 'query',
                    'einddatum': 'query',
                    'gerelateerdeactiviteitidentificaties': 'query',
                    'inclusiefvervallen': 'query',
                    'juridischeregelvooriedereenidentificaties': 'query',
                    'laatstewijzigingsdatum': 'query',
                    'naam': 'query',
                    'vanafdatum': 'query',
                },
                'collection_format_map': {
                }
            },
            headers_map={
                'accept': [
                    'application/hal+json',
                    'application/problem+json'
                ],
                'content_type': [],
            },
            api_client=api_client,
            callable=__getactiviteiten
        )
