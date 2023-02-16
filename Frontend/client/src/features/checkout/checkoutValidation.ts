import * as yup from "yup";

export const validationSchema = [
  yup.object({
    fullName: yup.string().required("Full name is requred"),
    address1: yup.string().required("Address1 is requred"),
    address2: yup.string().required("Address2 is requred"),
    city: yup.string().required("City is requred"),
    state: yup.string().required("State is requred"),
    zip: yup.string().required("Zip is requred"),
    country: yup.string().required("Country is requred"),
  }),

  yup.object(),
  yup.object({
    nameOnCard: yup.string().required(),
  }),
]
