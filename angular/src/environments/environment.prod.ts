import { Environment } from '@abp/ng.core';

const baseUrl = 'http://localhost:4200';

export const environment = {
  production: true,
  application: {
    baseUrl,
    name: 'Studio',
    logoUrl: '',
  },
  oAuthConfig: {
    issuer: 'https://localhost:44383',
    redirectUri: baseUrl,
    clientId: 'Studio_App',
    responseType: 'code',
    scope: 'offline_access Studio',
  },
  apis: {
    default: {
      url: 'https://localhost:44383',
      rootNamespace: 'TN.Studio',
    },
  },
} as Environment;
