"""
    Plan SW - Toepasbare regel SW

    Nog in te voorzien  # noqa: E501

    The version of the OpenAPI document: 0.0.1
    Contact: robert.melskens@vng.nl
    Generated by: https://openapi-generator.tech
"""


from setuptools import setup, find_packages  # noqa: H301

NAME = "openapi-client"
VERSION = "1.0.0"
# To install the library, run the following
#
# python setup.py install
#
# prerequisite: setuptools
# http://pypi.python.org/pypi/setuptools

REQUIRES = [
  "urllib3 >= 1.25.3",
  "python-dateutil",
]

setup(
    name=NAME,
    version=VERSION,
    description="Plan SW - Toepasbare regel SW",
    author="OpenAPI Generator community",
    author_email="robert.melskens@vng.nl",
    url="",
    keywords=["OpenAPI", "OpenAPI-Generator", "Plan SW - Toepasbare regel SW"],
    python_requires=">=3.6",
    install_requires=REQUIRES,
    packages=find_packages(exclude=["test", "tests"]),
    include_package_data=True,
    license="European Union Public License, version 1.2 (EUPL-1.2)",
    long_description="""\
    Nog in te voorzien  # noqa: E501
    """
)
