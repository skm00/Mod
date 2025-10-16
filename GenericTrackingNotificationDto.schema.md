# GenericTrackingNotificationDto schema

This document summarizes every field defined in [`GenericTrackingNotificationDto.schema.json`](GenericTrackingNotificationDto.schema.json).

## Top-level object
- **$schema**: `http://json-schema.org/draft-07/schema#`
- **$id**: `https://example.com/schemas/GenericTrackingNotificationDto.json`
- **Type**: `object`
- **Required properties**: `event`, `timestamp`, `shipmentDetails`

### Properties
| Property | Type | Description |
| --- | --- | --- |
| `event` | `string` | Notification type. |
| `timestamp` | `string` (`date-time`) | Timestamp of the notification. |
| `shipmentId` | `string \| null` | TMS shipment ID. |
| `bookingPartyId` | `string \| null` | Booking party ID. |
| `bookingId` | `string \| null` | Booking ID. |
| `eventDetails` | [`EventDetails`](#eventdetails) \| `null` | Detailed information about the specific event. |
| `shipmentDetails` | [`ShipmentDetailsAPI`](#shipmentdetailsapi) | Complete shipment context. |

## EventDetails
- **Type**: `object`
- **Required properties**: `eventCode`, `eventDescription`, `newDate`

| Property | Type | Description |
| --- | --- | --- |
| `isDateCancelled` | `boolean \| null` | Flag to indicate if the event has changed. |
| `isDateChanged` | `boolean \| null` | Flag to indicate if the event is cancelled. |
| `isNewDate` | `boolean \| null` | Flag to indicate if the event is new. |
| `eventCode` | `string` | Event code such as `ESTIMATED_PICKUP`, `ETA`, or `ARV`. |
| `eventDescription` | `string` | Event description. |
| `newDate` | `string` | New event date. |
| `oldDate` | `string \| null` | Old event date. |

## ShipmentDetailsAPI
- **Type**: `object`
- **Required properties**: `childShipmentIds`, `product`, `dateTime`, `events`, `proofsOfDelivery`

| Property | Type | Description |
| --- | --- | --- |
| `bookingId` | `string \| null` | DSV Booking id – Identifier of the Booking. |
| `shipmentId` | `string \| null` | DSV Shipment id – Identifier of the shipment. |
| `masterShipmentId` | `string \| null` | Identifier of the DSV Shipment master ID. |
| `childShipmentIds` | `string[]` | Identifier of the DSV Shipment child ID list. |
| `status` | `string \| null` | Overall booking/shipment status. |
| `product` | `object` | Product definition (see `Product` DTO). |
| `parties` | `object \| null` | Parties involved in the shipment (see `Parties` DTO). |
| `dateTime` | `object` | Date/time section (see `DateTimeSection` DTO). |
| `references` | `object[] \| null` | References used in the booking/shipment (see `TypeValueDTO`). |
| `bookedBy` | `string \| null` | Name of the user that submitted the booking. |
| `events` | `object[]` | Track and trace events (see `EventApiDto`). |
| `packages` | `object[] \| null` | Package details (see `PackageDTO`). |
| `transport` | `object \| null` | Transport information (see `TransportApiDto`). |
| `containers` | `object[] \| null` | Container details (see `ContainerSummaryDTO`). |
| `deliveryInstructions` | `string \| null` | Free-text delivery instructions. |
| `pickupInstructions` | `string \| null` | Free-text pickup instructions. |
| `shipmentNotes` | `string \| null` | Shipment notes. |
| `incoterms` | `object \| null` | Incoterms information (see `IncotermsDTO`). |
| `serviceLevel` | `object \| null` | Service level details (see `ServiceLevelDTO`). |
| `goods` | `object \| null` | Goods description (see `GoodsApiDto`). |
| `issues` | `object[] \| null` | Issue details (see `IssueAPI`). |
| `publicShipmentId` | `string \| null` | Global unique identifier of this shipment (GUID). |
| `carrierTrackingId` | `string \| null` | Carrier-provided tracking identifier. |
| `proofsOfDelivery` | `object[]` | Proof of delivery information (see `DocumentDto`). |
| `selectedServices` | `object[] \| null` | Service selections (see `Service`). |
| `customs` | `object \| null` | Customs information (see `CustomsApiDto`). |

