﻿using System;
using System.Collections.Generic;
using System.Text;

namespace imtif.x
{
  public enum IMTIF
  {
    IMTIF_CALLBACK_CONNECTED = 0,
    IMTIF_CALLBACK_DISCONNECTED,
    IMTIF_CALLBACK_READ,
    IMTIF_CALLBACK_READFROM,
    IMTIF_CALLBACK_URI,
    IMTIF_CALLBACK_POST,
    IMTIF_CALLBACK_GET,
    IMTIF_CALLBACK_SSL_TLS,
    IMTIF_CALLBACK_SSL_TLS_READ,
    IMTIF_CALLBACK_SSL_TLS_WRITE,
    IMTIF_CALLBACK_PRE_OPEN,
    IMTIF_CALLBACK,
    IMTIF_WRITE,
    IMTIF_FD,
    IMTIF_FDSET,
    IMTIF_FUNCTIONS,
  };

}