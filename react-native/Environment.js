const ENV = {
  dev: {
    apiUrl: 'http://localhost:44383',
    oAuthConfig: {
      issuer: 'http://localhost:44383',
      clientId: 'Studio_App',
      clientSecret: '1q2w3e*',
      scope: 'Studio',
    },
    localization: {
      defaultResourceName: 'Studio',
    },
  },
  prod: {
    apiUrl: 'http://localhost:44383',
    oAuthConfig: {
      issuer: 'http://localhost:44383',
      clientId: 'Studio_App',
      clientSecret: '1q2w3e*',
      scope: 'Studio',
    },
    localization: {
      defaultResourceName: 'Studio',
    },
  },
};

export const getEnvVars = () => {
  // eslint-disable-next-line no-undef
  return __DEV__ ? ENV.dev : ENV.prod;
};
